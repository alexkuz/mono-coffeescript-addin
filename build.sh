#!/bin/sh

PROJDIR=MonoDevelop.CoffeeScript
BUILDDIR=$PROJDIR/bin/Release

xbuild /p:Configuration=Release $PROJDIR/MonoDevelop.CoffeeScript.csproj

# cp $BUILDDIR/MonoDevelop.CoffeeScript.dll build/

zip -j build/MonoDevelop.CoffeeScript.mpack $BUILDDIR/MonoDevelop.CoffeeScript.dll $PROJDIR/MonoDevelop.CoffeeScript.addin.xml $PROJDIR/addin.info

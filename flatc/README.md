This folder contains different versions of flatc.exe.

* flatc-1.11.1.exe is version 1.11 of Google FlatBuffers repository
* flatc-1.15.1.exe is version 1.11 with Python language included in SupportsAdvancedUnionFeatures.
* flatc-23.3.3.exe is latest version of Google FlatBuffers repository without the fix.

gen-fbs.ps1 is a PowerShell script that generates code from an input fbs schema. You can specify which flatc.exe version to use and target language you want to generate code.

```
gen-fbs.ps1 {location_of_fbs_schema} [-NewVersion|-FixVersion] [-native|-net|-python|-python2]
```

`NewVersion` will use flatc-23.3.3.exe
`FixVersion` will use flatc-1.15.1.exe
By default, it uses flatc-1.11.1.exe

`python2` will use `--gen-onefile` argument that generates code without creating folder structure. Only flatc-23.3.3.exe creates a file for each type defined in a fbs schema.

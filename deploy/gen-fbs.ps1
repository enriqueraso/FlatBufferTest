[CmdletBinding(DefaultParameterSetName='Default')]
param([Parameter(Mandatory)]
     [string]$file
	 ,[Parameter()]
	 [switch]$NewVersion
	 ,[Parameter()]
	 [switch]$FixVersion
     ,[Parameter(ParameterSetName='native', Mandatory)]
     [switch]$Native
     ,[Parameter(ParameterSetName='net', Mandatory)]
     [switch]$Net
	 ,[Parameter(ParameterSetName='python', Mandatory)]
     [switch]$Python
	 ,[Parameter(ParameterSetName='python2', Mandatory)]
     [switch]$Python2
)

if ($NewVersion)
{
	$flatc = ".\flatc-23.3.3.exe"
}
elseif ($FixVersion)
{
	$flatc = ".\flatc-1.15.1.exe"
}
else
{
	$flatc = "C:\DevStudio\Extra_x64\FlatBuffers_1_11_1\bin\flatc.exe"
}

Write-Verbose $flatc

if ($Native)
{
	& $flatc --cpp --scoped-enums --no-includes -o .\native $file
	return
}

if ($Net)
{
	& $flatc --csharp --gen-onefile -o .\net $file
	return
}

if ($Python)
{
	& $flatc --python --no-includes -o .\python $file
	return
}

if ($Python2)
{
	& $flatc --python --gen-onefile --no-includes -o .\python2 $file
	return
}

throw "Unkwnon option"
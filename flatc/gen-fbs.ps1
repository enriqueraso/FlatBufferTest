[CmdletBinding(DefaultParameterSetName='Default')]
param([Parameter(Mandatory)]
	 [string]$file,
	 [Parameter(Mandatory)]
	 [string]$outputDir = "..\examples"
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
	$outputDir = "$outputDir\generated_NewVersion"
}
elseif ($FixVersion)
{
	$flatc = ".\flatc-1.15.1.exe"
	$outputDir = "$outputDir\generated_FixVersion"
}
else
{
	$flatc = ".\flatc-1.11.1.exe"
	$outputDir = "$outputDir\generated_CurrentVersion"
}

Write-Verbose $flatc

if ($Native)
{
	& $flatc --cpp --scoped-enums --no-includes -o "$outputDir\native" $file
	return
}

if ($Net)
{
	& $flatc --csharp --gen-onefile -o "$outputDir\net" $file
	return
}

if ($Python)
{
	$folderName = Split-Path $file -leaf
	$output = & $flatc --python --no-includes -o "$outputDir\python\$folderName" $file
	if ($LASTEXITCODE -ne 0)
	{
		$output | Out-File -FilePath "$outputDir\python\$folderName.error"
		Write-Error $output
	}
	return
}

if ($Python2)
{
	$folderName = Split-Path $file -leaf
	$output = & $flatc --python --gen-onefile --no-includes -o "$outputDir\python2\$folderName" $file
	if ($LASTEXITCODE -ne 0)
	{
		$output | Out-File -FilePath "$outputDir\python2\$folderName.error"
		Write-Error $output
	}
	return
}

throw "Unkwnon option"

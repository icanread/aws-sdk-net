param (
    [switch]$Release = $false
)

if ($Release)
{
	$Config = "Release"
}
else 
{
	$Config = "Debug"
}	

$ProjectPath = "..\..\icr-cognito\icr-cognito-unity"

cp -Force -Recurse -Verbose sdk/src/Core/bin/$Config/netstandard2.0/AWSSDK.Core.dll $ProjectPath\Assets\Packages
cp -Force -Recurse -Verbose sdk/src/Services/CognitoIdentity/bin/$Config/netstandard2.0/AWSSDK.CognitoIdentity.dll $ProjectPath\Assets\Packages
cp -Force -Recurse -Verbose sdk/src/Services/CognitoIdentityProvider/bin/$Config/netstandard2.0/AWSSDK.CognitoIdentityProvider.dll $ProjectPath\Assets\Packages
cp -Force -Recurse -Verbose sdk/src/Services/CognitoSync/bin/$Config/netstandard2.0/AWSSDK.CognitoSync.dll $ProjectPath\Assets\Packages
cp -Force -Recurse -Verbose sdk/src/Services/DynamoDBv2/bin/$Config/netstandard2.0/AWSSDK.DynamoDBv2.dll $ProjectPath\Assets\Packages
cp -Force -Recurse -Verbose sdk/src/Services/SecurityToken/bin/$Config/netstandard2.0/AWSSDK.SecurityToken.dll $ProjectPath\Assets\Packages
#cp -Force -Recurse sdk/src/Services/S3/bin ./


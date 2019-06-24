./build.bat

cp -Force -Recurse -Verbose sdk/src/Core/bin ./
cp -Force -Recurse -Verbose sdk/src/Services/CognitoIdentity/bin ./
cp -Force -Recurse -Verbose sdk/src/Services/CognitoIdentityProvider/bin ./
cp -Force -Recurse -Verbose sdk/src/Services/CognitoSync/bin ./
cp -Force -Recurse -Verbose sdk/src/Services/DynamoDBv2/bin ./
cp -Force -Recurse -Verbose sdk/src/Services/SecurityToken/bin ./
#cp -Force -Recurse sdk/src/Services/S3/bin ./


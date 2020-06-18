cd
::%comspec% /k "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\VC\Auxiliary\Build\vcvars64.bat"
::dir /s C:\projects\goinpostal
::devenv.....
mkdir "C:\projects\goinpostal\bin\Debug\netstandard1.4"
dir /s C:\projects\goinpostal\bin\Debug\
"C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\devenv.exe" GoinPostal.sln /Build
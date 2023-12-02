$Signature = Get-FileHash -Path "index.html" -Algorithm SHA256
$SignatureBytes = [byte[]] -split ($Signature.Hash -replace '..', '0x$& ')
$SignatureBase64 = [System.Convert]::ToBase64String($SignatureBytes)
$NewHash = "sha256-$SignatureBase64"
Write-Host $NewHash
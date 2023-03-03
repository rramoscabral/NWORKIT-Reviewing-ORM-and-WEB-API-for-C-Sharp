# Create a self-signed private key with a key size of 2048 bits
New-SelfSignedCertificate -Type `
    Custom -Subject "E=dev@digitaltraining.pt,CN=Dev Team" `
    -FriendlyName "Developer testing Only" `
    -KeyFriendlyName "Developer testing Only" `
    -KeyAlgorithm RSA -KeyLength 2048 -SmimeCapabilities `
    -KeyUsageProperty All `
    -CertStoreLocation "Cert:\CurrentUser\My" 

# Certificate manager
certmgr -s my

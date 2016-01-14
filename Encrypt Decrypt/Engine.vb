Imports System.Security.Cryptography
Imports System.Text
Imports System.IO

Public Class Engine

    Public Function doEncryption(input As String) As String
        Dim Password As String = "Visual Basic 2010" '"Password"
        Dim SaltValue As String = "System Library" ' "Clave"
        Dim HashAlgorithm As String = "SHA1"
        Dim PasswordIterations As Integer = 2
        Dim InitialVector As String = "AbCdEfGhI135792468"
        Dim KeySize As Integer = 256

        Try

            Dim InitialVectorBytes As Byte() = Encoding.ASCII.GetBytes(InitialVector)
            Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(SaltValue)
            Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim password2 As New PasswordDeriveBytes(Password, saltValueBytes, HashAlgorithm, PasswordIterations)
            Dim keyBytes = password2.GetBytes(KeySize / 8)
            Dim symmetricKey As New RijndaelManaged()

            symmetricKey.Mode = CipherMode.CBC

            Dim encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, InitialVectorBytes)
            Dim memoryStream As New MemoryStream()
            Dim cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)

            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)

            cryptoStream.FlushFinalBlock()

            Dim cipherTextBytes = memoryStream.ToArray()
            memoryStream.Close()

            cryptoStream.Close()

            Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)
            Return cipherText

        Catch

            Return Nothing

        End Try
    End Function

End Class

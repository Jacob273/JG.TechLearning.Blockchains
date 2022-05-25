using System;

namespace Asymmetric.Implementation
{
    /// <summary>
    /// Private generated with: openssl genrsa -out private.pem 2048 (generates 2048-bit RSA in base64 format and PEM).
    /// Public generated with: openssl rsa -in private.pem -outform PEM -pubout -out public.pem (pem + base64)
    /// </summary>
    public static class AsymmetricKeyInformation
    {

        public static readonly int AsymmetricKeySizeInBits = 2048;
        public static readonly string RsaPrivateKeyPemInBase64 = @"-----BEGIN RSA PRIVATE KEY-----" +
            @"MIIEowIBAAKCAQEAm+ICja18aF3PpcSVKAxcW6BCCPdNSOC5kuvH3YWW+LYNu/Zg" +
            @"1rgTF6CCpnlLMgosrJtn5Gx9Gmsq04QDbp3MGm9+ebG+brY5ooLzwvm0zSTwLBn0" +
            @"JQYT1FhpM6jqjIitdF486LZqP+8N+IX7cFJBU8Tzvv/IXPI9qqK8WbYCOCVVET+L" +
            @"bAXs/QFnEaILve6RXpcfiCPhlCIDs+I7NwLr25ru3hJ5ArJPu3qJl94GS9d0iqjK" +
            @"PmQC+8hPC207jPKAebF206wBVHIwnGCEtnGg4pJVcSVoSz8OZHn6Bo9RFkYnSvWo" +
            @"ZOZOy5A+/nJI1vxP9gaAYYrRxYJ9g1cWvY/QyQIDAQABAoIBAEfmEu9uGXe57VC0" +
            @"P2fda6wHWu3vwwHeRTny7pjKSTwmHGeZ2EixVn0LV7eZMom+D6T9eQnu0DUjQPmW" +
            @"Zk7bEY0P5/IRfZhrDGJcrDo+GpqUcwKkZeu9xd+nd76QJr7zO6302XssyAz9IiCD" +
            @"C9pe1irhKNvr9mqIgND3hpCKVrO2LAYWTgqlzala4r6jiMG2Im7vxHH+Ll4DVKkU" +
            @"IigyarHqBnn6yV0bzAX8PL5UT1VrrsBpnWleefPuTKb4urWjEta6ILAt7Pqm33mT" +
            @"c3Wl5MbUjye7TJn/QDGlGdJrBQPu+/vz9IhoOMr2fU3OhhUZQQSfSC8TbNRpFZzi" +
            @"SFFMBUECgYEAztgnr6aTJ3/+wu5IFBKzFa5fZqXwBUkZIWPp+OGdigIQnaubt7iV" +
            @"tXZXxWRpsZReA7uWkTLp6lvK3Kkln2enGDnsfNbDosBfCbbzTbSP9v+ahPvh1toG" +
            @"vA1A3vRHzTPf2gq5x62qkKEvcuUXC8yUfhteaPopymI+fiyBsFCQ290CgYEAwO1/" +
            @"E8KR9+/G83ZlUiy3IP5Zxc8tDGUsKPlXqPmFEMgwk6Cvb1g6Z1+XNWR2wYLoR/Qp" +
            @"g5SS1NGmYYDBndpymPsyTIYd4i5qII6/Ujv3mDsrY/N/oJLk1TrBoUqs8cCxcGxO" +
            @"krr8uToAP65YDheFaMoFYPZWqeRIWatjf81nX90CgYEAt+FXHoLR7NqPi5EzCI07" +
            @"ITob23AG+VvreFCPTk6bs3V0egZ17xSsGl5zVqqWf2RrU5wvFTOS2WHy7Ml+BcCq" +
            @"vhG4V57A2m1zz3oRv3GWTjkaj8AwG8VFGWYa1lmJfzXvebHxSD7uE5cHTHe2Tin3" +
            @"lEgWXPKPtjgyYA6G2Ew3Cw0CgYBpA52NSvabZ8f6k/KY5UAVVH3XH2tc+OEtuHOP" +
            @"xao5tU5DvU5hJDw+Mpki9flyYeg/6laCiefWsfuHzUcWvmZsgSci4kn36N3ZtPnN" +
            @"MFkYYvS+ZjeNVwf6TQ5C1lwHB6VOFZY7Zk7UIA8smqDRotn6bSS6X7xSo7ECJjl1" +
            @"wn/HfQKBgCW5FRFGIgxZSpx89zXRsRxjzOwcpz4G+ryYFjiLcxNWzEFpBvXTm3+B" +
            @"L4syGfrMKDoIk/O8W2OHaF3GlsHgZx8CI3RClpCr986ViQ95roETsv65yIrQDUTa" +
            @"snxYlQklGozXjnHlqQl6EJaXf49HfF47mkehlZNLbcaCio3XWTFB" +
            @"-----END RSA PRIVATE KEY-----";

        public static readonly string RsaPublicKeyPemInBase64 = @"-----BEGIN PUBLIC KEY-----" +
            @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAm+ICja18aF3PpcSVKAxc" +
            @"W6BCCPdNSOC5kuvH3YWW+LYNu/Zg1rgTF6CCpnlLMgosrJtn5Gx9Gmsq04QDbp3M" +
            @"Gm9+ebG+brY5ooLzwvm0zSTwLBn0JQYT1FhpM6jqjIitdF486LZqP+8N+IX7cFJB" +
            @"U8Tzvv/IXPI9qqK8WbYCOCVVET+LbAXs/QFnEaILve6RXpcfiCPhlCIDs+I7NwLr" +
            @"25ru3hJ5ArJPu3qJl94GS9d0iqjKPmQC+8hPC207jPKAebF206wBVHIwnGCEtnGg" +
            @"4pJVcSVoSz8OZHn6Bo9RFkYnSvWoZOZOy5A+/nJI1vxP9gaAYYrRxYJ9g1cWvY/Q" +
            @"yQIDAQAB" +
            @"-----END PUBLIC KEY-----";
    }
}

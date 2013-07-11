namespace JabbR.Models.Migrations
{
    using System.Data.Entity.Migrations.Infrastructure;
    
    public partial class UserSalt : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201111302209099_UserSalt"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "H4sIAAAAAAAEAOy9B2AcSZYlJi9tynt/SvVK1+B0oQiAYBMk2JBAEOzBiM3mkuwdaUcjKasqgcplVmVdZhZAzO2dvPfee++999577733ujudTif33/8/XGZkAWz2zkrayZ4hgKrIHz9+fB8/Iv7Hv/cffPx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+g3Th6fzhbv0p807fbQjt5cNp99NG/b1aO7d5vpPF9kzXhRTOuqqc7b8bRa3M1m1d29nZ2Du7s7d3MC8RHBStPHr9bLtljk/Af9eVItp/mqXWflF9UsLxv9nL55zVDTF9kib1bZNP/so+9kk8mrsbT7KD0ui4xweJ2X5++J0M5DIPSR7Yo6OyWk2us316ucO/zso5N51p6URb5s/XbU8vfKr4MP6KOXdbXK6/b6VX6ub1Ojj9K74Yt3u2/a9/yXgMJnH50t23t7H6Uv1mWZTUr64Dwrm/yjdPXpo9dtVeef58u8ztp89jJr27ymaTmb5TwEJcWj1ae3o8bDuzt7oMbdbLms2qylOe5h3sHzbGbQfN3WxCwfpc+Kd/nseb68aOcW1S+yd+YT+vWj9KtlQbxFL7X1OveHJn93unyRXRYXjE2n86+avP4ofZWX/GUzL1bCAmM3Yb+/tHlWV4tXFXrofPX7v67W9ZT6fFPFv3+T1Rd5G+L0+K5jkRsZhxH4Edv88Nmm0yX+/aF3+u2smf/QO32dle0PvVOMFLzUNFdV/cOf3edZ0x5P2+KS+Vc6f0rc/abArPeE4GZgL9azi9yOIwbqNmi9JnFYNzeJ5G31HdnHZT4lkRUF1Xyo7jO6bUj3Gd14W/y+vFrms1dVtRjGDN/+/mhXN13MvK+imPnfvy9mm5HiwWqTECf3TdRQeF9/sJ0AmB/ZiZ81SfzhqP9h0a3zjKi5WS5so4hg6HdRNgwaxBjxJqGtP1hgB9HqCPRtsfoib5rsIh/GSxuw9HUR87+LqpKgwfvqEgj9B+qSGE4RVfO1dYmO70fqpG9AW0RxP+t64Ofe3f3uPF92deaX5+cN2O5rOyAibB8qkTFdERXZ26K1MQ40kGPOkP/dRrQ+PBSkxMkXeZvNsjb7OmIJDnpfqXRc9/9qoeQczg8hUBqaquOmqaYFo9pxx6xBDvE/Xc7Sm6yzDMQ3ooT7umyLVVlMCYnPPvpWjy4b4FqDEcIVng7h7ozHu92Be0O85cjV4t+IYNf8f0Pj7oYBNw+7A/Y9xxzork3YxRVZiJ6xvu858LjXcjNBP3jCAw15GwxDdfmNDj6MS2+e9g8evOevbcIvFgjejN1No465hDdP+Iexup8b4NYDuEWTpCFymhN/z0FHMxA303I3xJbAfrl8mpd5m6dI/GA54iRrptms78+Q4p/dhmBiH+AkZgXpHyUaVhpq9hzfdfP/8sLrvDX0NXkZZ2ki5OpRJwSi8UUUhBDmBgAafUQBCD/dAMAFX1EYVsRvAOO5PDFQvkfUBeVNkEfdjlWkZR/XbCiW7jLNLYy3HYclZYjdZiiGpT0oOqNdrgwH+T4EMPH4hvHHDHgc8Y4J/3qj7xjsn6XBhyFGfPTDpryHedSYe6g7ObiBBFHTfRMhP5AGogo206Cv5AdRD/T8h9Ag0Os/S3zgJ1niFBgy6z20I4b9JqQ3wfhZnvwgsR8f+aB976FtWg7MvDVmN4w+Zs8/YN5NmGbNsP3u8d3XHHrqB4/vUpNpvmrXWfkFYsjGfPFFtlpRBGn+dp+kr1fZFGhvv9bA9nZR7cFdCmwXAuPuNGCprtNgeyJbQOLQ+Za6JkyfFXXTUlImm2SIaU9mi16z2zgdpqvQ9+hPlrG7pj1+d67Nq7EQz3dROjAcAZ/RmBbUgoengxNm2fAyvf56mpVZHcsanlTlerEczD1ueh/5Df/1fo6E373bwb1LIC8toC07rNol+K2mQ9j+gyYjJsK3nIr4qz+3EzH0Nv4N35dPbg9Bkkc+BPnk9hBkydyHIJ/cHkJ3/buLjf/d7aGGy9o+zPCb94NoVtS68Mznt4dm1rcDyuln/68RxSE34D1EMeZM3lIU46/+bIniNzu9txfNn6Optd7pB81udLmMwdxmggff/tmaY7uK5cOwH94ezoepbVlg8t+XT/5fwxtB+uFr88fgug2DuYk/Nr79szMvjHffInof//BnKHT2O35rL6tzgx52DW+rbhGwdGVoIG3TJ83tRNiAiYoyJyANhK+BmwZnXxe398eJlMms4LzxWYMlNbv8dsshd8O7r88UJtN1E0+YdkMsMeQUbyJ/mBj7utS34N5/Gm7G7UO5dp61HLe/J27fyPyGybybzbM2fA8TPEDAWLbu61LwG53ZWD7y6yL2/jjdSuiHxvuNcoSkt27BEdLwm+MIP4f1dQn/deTpdoj9v5Mjhsb7jXCEn+i9IVNimg2lQ97TOejnhb8u3b+ukr0Nah/Iq1/XNn0jcxvksm/MSW6Q9XjecYB4kWz116XeNzqpkWT818XrPVG6eTJ7KfluExs/6Cf2b5uS13S4TKt7TxL6PJBGU/Pd/Lg0+Sgl3C+LGXLjr6+bNl+M0WD8+heVZlndNPgiWxbnedO+qd7mtDCC9D2tlZRF1sgqyXtl/h/e3dm7m88Wd5tmVvoz4kWQvVkMZ+4xzUd3MsxEvMrP/VnsatDum/Y9/yVZUi9AApaOz3OaoaxFwrFt83qJADJnZD9KocWzCVZuVJN3euzAR+Qp4JeXWT2dZ/XWInt3x4fT1usbwThB8XDdiIofcN5I9L5f/yOS499vBJCkDL4BQJJQ/wYAdbPp3wDIMJkuAClnk7cFqPieM+inWodB3QYtk0n/WZGavi/0/2Gp+eZo/o0JTpAeic5gH8p7TWA0xPk6c6hd/1zPoc1gfwPE/4a0qGS0Q4aqzs+b/CZJ7INybvYteaEP4gYz+gHsNJimvh079RPUN3OTm6GfFWZiR/Nr2q5bk82o0Q9xQm4IweIvDMfcN5E97O62hiUO54fg1n2Ioboh7n6/qbgdZd+fIt/UDA1R1gvtPPh+SB0iQ0Fi+qoqvfEYHBA62WTLR+kX67ItVmUxpU4/+2i3F31/uXyal3mbp/CrKhLlk6yZZrP+8BGXbsLBhHcdLMzHIR7f6oGn6c1rKJGsJAPTtDUFsL3lrZd1sZwWq6zsjr3TMMo2cfa6a2F2v3mar/Il9Fp/kLfpblPWwYLukHgDEbSFxyc3s0+wCveN8M/OeLzbm7oQllsm8GDJh///4IFYcjKupzavNVrYP7tMEKzKfCMTdwsmMD5vF5z9/GeNFW49O98EKwysXkT725S/tbB/OKzwzdmT/1ezwg9VK7wPK/y/xTRsWDj/urrhZ9HBCDz4GC5DTPoNstQPVbsMhyz8yvs5xj9HvBVbuvm6yub/57x162n+OeOt/xfoLUZheLn3/4WsFYTHMVyGVOn/V1lrOB/Ar/x/gbVuobX+32AR/9/AWree5Z8z1vqhWsRTzu7YBXiDRnexvMdaeIvW9Hu5n49S+W4gqyKL7pT0nlTEAJJ1ct83Ede835How2g38tVQJ/j2dl0ID0a7kK+GumBxvFUXNpyI9mK/HepIG9zcl5+C7/cVfBvrK2hwi2GFvscgBW+eLL/VzaPsK5BB/rh5Ev1W/a49QYoJgASrqdeqJwaReDaqKs0gqBv/w55WCN8M5dC+az7uquxwOLccKqsok6gbGGvQ5mdrsP5c2zflw29koEEyamCgwwmrr49u782OurAv28+/0eFu4uHhpMw3OK8/nOEyi4ZJhU3MvCH98A3OdEyDBhCGiPgNEEH9yFsQIeZxBkM5mWcfMP8/bCJ4vvRmRug3/NkiQcycBRCGOOrDSbCZDfoNb57LrycKPxskMAua1uW13z2+Kw6BfkB/kuUiZfMFlvwb/pQc7TW9vZClUHL5m+LCgXhMMJc5x0gOqGlztjyvjL/fwcg06SzYGr/ruG6L82za0tdTUn/F8uKj9Cezcg3vbDHJZ2fLL9ftat3SkPPFpAziBkQMm/p/fLeH8+MvV/ir+SaGQGgWNIT8y+WTdVHOLN7PIgvNAyAQinye0+cylxTZtPnFtYX0olreEpCS76mJoN7ki1VJwJovl6+zy3wYt5tpGFLs8dMiu6izhU9B+UQxeZ1Rz14X1IH/huuP/iR2nS3eHf0/AQAA//+T6kWKS2UAAA=="; }
        }
    }
}
using AutoMarket.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.Infrastructure.Data.Seed
{
    internal class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder
                .HasOne(c => c.Category)
                .WithMany(c => c.Cars)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasOne(c => c.Seller)
               .WithMany(s => s.Cars)
               .HasForeignKey(c => c.SellerId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                 new Car
                 {
                     Id = 1,
                     Year = 2022,
                     Color = "Black",
                     Price = 25000,
                     Description = "A sleek SUV with advanced features",
                     CategoryId = 1, 
                     Manufacturer = "Toyota",
                     Model = "RAV4",
                     SellerId = 1 ,
                     ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQuDg8HD_l73IKAZ89VpH9kFI01qNJAj3kZMA&s"
                 },
                 new Car
                 {
                     Id = 2,
                     Year = 2021,
                     Color = "White",
                     Price = 30000,
                     Description = "A stylish sedan with comfortable interiors",
                     CategoryId = 2, 
                     Manufacturer = "Honda",
                     Model = "Accord",
                     SellerId = 1 ,
                     ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTpfTyeizNqCL05LDBAT5r22zx3wYlyQndMsQ&s"
                 },
                 new Car
                 {
                     Id = 3,
                     Year = 2023,
                     Color = "Blue",
                     Price = 35000,
                     Description = "A powerful truck for rugged terrain",
                     CategoryId = 3, 
                     Manufacturer = "Ford",
                     Model = "F-150",
                     SellerId = 1 ,
                     ImageUrl = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxMTEhUTExMWFhUXFxgXFRgYGB8YFxgXGBcWFxcWGhgfHSggGBolHRcVITEiJSkrLi4vFx8zODMtNygtLisBCgoKDg0OGhAQGy0lHyUtLS0tLS0tLi0tLS0tLS0tLS0tLS0tLS0tLS0tLS0rLi0tLS0tLS0tLS0tLS0tLS0tLf/AABEIAJ8BPgMBIgACEQEDEQH/xAAbAAACAwEBAQAAAAAAAAAAAAADBAIFBgEAB//EAEsQAAECAwQGBggCBwYEBwAAAAECEQADIQQSMVEFQWFxgZEGEyKh0fAUMkJSYrHB4RWSI0NTcoLS8RYzY6KywoOT1PIHRFSjs8PT/8QAGQEAAwEBAQAAAAAAAAAAAAAAAAECAwQF/8QAMhEAAgECBQMBBwQBBQAAAAAAAAECAxEEEhMhMUFRYRRCgZGhsdHwBSJSccEGMmKy4f/aAAwDAQACEQMRAD8A1lplKlEdsqVtFIinSq3F+J9VakBigLHOFZsgqqUqScg7R4yjFr91meld9C7RpVCQCQ2UMS9IpX94qrFIlrDTAae8PrELVoAfqzroQaQoOktnsKam+C5VLScQ+Udl2dAwITvGPdFLK0TaUjszTzML2mdaZfZMxTRctOo7fcmKnBGllWdAqFgbgR4Q4mbRr7jl9IwyrbPYXZytxAhc6VtB9tQ5RpDDwX+1/UznUm+Ub5MvUMD5zjibCgYhXDxjGSNJWkl73Og5CCy+kE0HtpTwB8YHRi3d7jU5JdjWnRSBUIVX4oGJCdvP6Rm53ShQp1XMn+kCT0mWcJY5HxitFNXsTqO9rmqNklnUH3VhNWjZdSCBmQxirlaamGt0jhXmYck2lKvWBJOJLRyVbR6fM6KeZo6NDylUE0vkw+TxWWnowovcUk9xjRWOzgmiUnYS0WqpdA5SnYUg8o1w85tXW355+5nVUU7Pf88HzS0dHJqQ5+cJjQ0z3eMfSjLSXdT7AiFlaNT7IocSBTc1WMbyxdWC7mSw9KXKsfNp1gu7TC9wDVG+tOi5anDF3xbGKO2aMCagONoYxpR/UYz2fJFTBW3iZogZRJEtJzEWxsgFWAjn4clR9aOz1MWc/ppITFhSRRZfdC82zlOIMXf4SrUQ0e/C1NriViY9xvDPsZ4JTtgiZaG1xYztHKGqISbJWojbXi1e5joSuVq5Q1QApi8n2CjtFRNlHKNIVVLgidFx5Ah49ErpjoTGlzKxxMGloiIpqgqFnVCZSQeXZgdUFNmTqiCH1wZMsxi5eTaMb9AfVHOJ+juPCGJdkia7OwoYh1EaKkxA2Ya4XnS8oZUlWUDVeyi1LyZuPgU6sxJNnJgvayiQCsopyEoG0XpwgURX96nyiMvT8zXLHBUZYzztjwtJ1GPMVHax3uqrms/tBLPZUlSTroDEjp6WAyS/8LfWMmZ5OIeIlesOPlE+lh1Q9aXQ1svpFvgatMhWIDa3r9IyybQdkMIth1ofdCdBJbIqNS73NKFWdeSVbH8InKs9nOKg+bkRn5duzSRvg3pyDtjmdGXS/wATdVI9y6Oi75JCwQ1GNRFZNsSpa8CWzwjtntiQcW3Q/PtyWF4Be0Kr8oi84uxdovcjLtSbval12CnOCypElRvBKicnpyhZMyVkocAfrDVnmI1JX3eMc1SDSbjde81TT5JKkof17vw+EGs8oChqNjAwaVLvEHqZh208IZmWJgCQa+ySn6Rg6VRrYepFbEZls6pJuhT0xDkd0JWfTl5ZUuUr8rhxt1RaJsspnZW+8a8HLROXJSjtJl8Sp46o06nVq3v291jFyh23Kmfp5Sgf0aUNi/dD+irablMN/wBINNmBdFJBGVPqICES0hgG5eEW1JTzqQrxccthsWjF5prkHMAtKEkEqKlfvJZ+LwvNtE6nVpBaic+JaJG2znHWyk4VF4PvAjSU0473+f3JUGnt/grVIk6zrNCAYEvRspYdru12B5xcC1y19lpQ2Fvm1Ij1EpRdSBsqQ+xqvGSvG1n9S735RVTNElCXTMfLtDlFPalzU4vGqQEE3eqcZVcQlPTKJKQpIJ1E4HfG9Guuu5nUpv8Aoz0rSBdlJMMLUDWnGHrRokFmWAd4PKsK2nQk5KXdKhsqY6lKlJ82MXqR8iM6c9GELGWmDTdHzMSkjhCUySR70dcIx6M5Z1JdUS6mVrMd6qTthOZJXlHBY5mP1jbIv5GOo/4liJUnbEDIlvQxXLlKGuB1zh6XkHW8FzLkI96HEXG9Yxm7xGuOekqETKg31KjiUuhpJgGpUDMt8VCM/wCmqjxtqon08u5Xqol6ZSc3jxSjOKA2xURValZxXp5dxeqj2L8ol7Y9+jjOm2qziPpioPTS7i9XHsXEl/2vOLaxWGSfWmp4UipWgp9nlE5W7n9o4akXJbO39WOyDUXZr6l5+BSj6s4HiI6ejoxvuIrZatevdB0zzmY5nGquJ/I6Fk7FjK0PKSO2ATvI+UE/D7MMAeCie6KebPfbvJgaUh6O+wxKoz5c2Nzj0ijSyjJIuli2pRDwvNkyjTqFAPQgivI0ioRZ5hGBI2BjHFSlgMxHnbERpRi9pfnxKcm+UPWqzSEl24KZ+8vCE60I/V8jE5VmKsSl9ZJg34ckVdJPmm2LzQi/3NsVpPhWAydILAo22H7NpVhUEHu5RXWiRM1BhtELhK3YhO/yIHSpzV9gzyi7Gol6cVsIyOH2gq9NoAqGOYIjIKkzaszZmImyzcHTwgVCK9sl1H/E1M3TyAKVimm6eWpTXiN1IqvQl43m4QC6vI8I6IUKb63MZ1prpY0glFr6rRdB1FTE8Hh3RdoDduftFabHJavExiptpSlgosTgNZ3DGIzZxD9g0q5ISMW1mlWGx4JYPMrNiWK8G0maZQlV0TMMVgXjuDlvnHLRpZCyFdepLZAgn7xgZmkrpr1af3pqX5auMLL0+2HUtmZg3YBTngIF+nxXFweMfY3Fp0iSrsTJm8qx4RFekpj1mvzjEJ6SLGuzDX/eOw4KLnYHMGGmp5BXds5T73WMjdfJungY0WDXFiPUs2n4nMakwjuivXa1DXWMkrpiUkgolltaVEjhF5I0jelpmFN0KwFSeQBOW5xHTRwjXCRhWxS2vcfTaFE+sYN16vfPziuTpBHvAbCQn/Ux7oY6wEbM2pzwjR0Z9jJVod/jsXGj9MKQTUEba/OC2nSiVesgHdT5RRADGPBY8mOaWHi3ex0xrStYsFLQcA0JzpY1LjgUBnEKHPlGkVYUncAuST7UDVZhrVDKpZgapCso2U/Jg6fgXVKT7wiBQnZBzIOUeEjaOUXnI0wCVZNHirYIP1BzEeNl2wZ0GRiUxJ1CBmzqMPmzkRGkVqdiHS7leqzqygfUqyi1YR4ARWqLRJJWvMwRIV5aBBJiQeOHKdmYOEr2R7tZxBKjnHb+2JylZkTBOZiYc64Fe2x4HbCcRqQ9ZwvUVcIMZ0wUK1Mc4qxN2mCi1H3jGMqLb6G0a0Uhxn11yMdlAvq7zCRtAOLmOi1ZfKIdKVi1VjcvbPPWBiOZ8IgqYs/q33GKsW5bNWA2jSxQHXMuvSvhHL6WbeyXz/wbvEQS3ZcqllnMpXN492R7CxGc/tFJxNp/yzP5Y6el0kf+YUf+GT84t4LEPp/2X3Mlj8OvaXyZpEyRMBCSXxwYRntKaTKFGTKKJkwUJA7MvYc1fCMNeRQt/S6UpJQmfNTeoVJQxA1gVo+YqNWcVtn0nZJYARNWlv8ACBjow+BrRd58dF93YwrfqFGW0X7yy0foRalBUwrrUqHrcMouZmh7IiWpXVg3EEuoOaCgc8A0ZwdLLtE2pR/4YB/0kRGbpJU5Cnnz1JOKf0aRi4wQNkbyweLqS2dl4b+xlHG4WEeG35X/AKUtumDUByinnTjF5M0eg61/xKBDbQEgwJOhZZxmHl9o744OsuTkljKPT6GfUqIGNOOj0n9os/w/aDo6NSW/vSN4jVYWr+MzeMpefgZ7RdmvrSnM13eWHGPqcrQqygFN1gLoF4BTg9qh2uP4RFJono/KkK63rr90OxAq1TV4oj0tWyRLAcP1gUlzeepemJvGLnF0YJPlv6EU5qtUbXCX1NNpPRqygi6XFU01jAPtqNxMVujgCMKioOBY7cf6xXo6YztcuVvuqHyXFnNtyZU4Xk9hYlrDlzdmy0rI3BRWkbECMNRXOrLsP2eaUqAKiQrs1LkKPqlzUgmjF8QaMXItanxha0W2QpwHCSGOL14w5IX1yEzBUl0rb30G6otqBxGwiHUkmr9iIxtKy6gr5zjvWKzhmXYFqwSTDsvQU8/ql/lMcjxFNctHQqE30ZU31Zx0qVnFwro9Pu3uqU2GH0iunWFYd0mmyCNem3a6B0ZpcMWBOcRJOceUgxEJ2x0Kxg0z18xNM45mI3BnHLoh7C3QXrzHOt2CBkCOAQrIMzCP8IiJmbI8+yPCYcoB3DCOgRO7HbsYGpy7HrsTux5oQELsduxK7HbsAELseaCXY7dhWHcG0dETuR25CaKTJWeXeUxJAq5DEhgTQGjx8y09pgLmkoXNWn2QohBCdoDh3fA7I+nIN0KOSDs1iPiy5iHF6oKQQEm67u1SatWLh+3dClaWzLjRkgznqEtms+MFsujwu86gLvxmsUaJsoMyVa3Zbbva3R1M2XkvGrL1Oaeti13ziN1H7QKMF7KLmwWBEwqel0/tCHhCbMlhRT1SyxxE0t/phREyXkv1i/b9mrD1t0RBl07KsTe7YFKs3axwhpzvvIHGPYspEqVMvCWpaZiQ9xRBJHwlqn4Sxi+0HLsE0pQuXakrIJdM5F2gJOMonVGUsFsKFpAZxeL+sUgg0Cnw2bov+j2kEptUlS1yVoEztJDupLEKZkAijnEYcIrUkurJ04vojVo6K2FV9lW0dWWWQqWQn1jX9D8JjUdHui8tCpkqXMnX0y0TAJplqSQuiSShIIqzikUOhtKSpFp7RnISmYGSFXwFzU9Wyj7S2MyrUTrJjU2a3Js1mn29T3kWSUgFarwWskFBrVyss2TUEVHET9lsmWHg9pJHdGS5c6yi0A3dSkk1vOQQOUKzp4SwUyf3iEvuBNYz/Ru29XIT1hYB1rO1RcjfgIqNN/8AiR2yJSEpS+CUg7yST2jmanbHuSm6e8nz36ePJ4MKSqN5Vx26+fBe9JZyZlmWZBdSFJ6xKgzB7uFCzkF9kZ/RXQwlfWLuBMxFUqdTFQDsyhdL4HYc49ofTsudeRRKZgKF3Q118CB7LGrYYne6jTqpSRLXLN5IZTlnIJDilRTGMpwVWVnuuUdFN6MbrZ8fiBnoEm/ScbjVA9Z9ijQDhFz+BSAlKVXlMAkFRKlFgWDtvoIqj0p/w/8AN9or9J6TROUhSkrSU4XJjUOIIZsq40h+nhFbQQnXlJ7zfwNFM0HJzbfT5tBtHWYWdCuqVeUSpTXsXu9nHJIA3CKezdJkpSE3VMKOV3jxJqYDb9PKmLQpE5coJe8CgLB2+sHOqrjXjEVMNTcWnC99rDjWmpJ5+N+DdWPTC0pBRgoAuDiDUYiHpGmpqQ46wA62cdzxi+jukETewmpClu4bs9YsDuaLFFtKFBPaqSAo0x9XW43nwjxqn+nsLJZouUX4k+vxPSj+rV07Syy/tfaxpk6WmKD9apt5BhC06QVm++sCQq8hSjMJUCkFJLm6XZWeLiK+cuPFf6ZCnWlBtyXnc9qGKc6SlZJvsQthSouA2yEVAQdSoEqPXpLKrHDUd3cCUxG7BCI4RHQmczRBo40Sj0O5NiMecx2OQxFSOlg1SFmmog15Ybe6AS+lsy/Wz9jJzeHHA8op5KEkO487I6mUHpd5Z+RHDreDr00X0jpggqIVKUBqIN47iGGvbBldLJYZ5a66hiObDkYzSJfs3nbV51RIJG+FrD00aodJ5BSSBMcezdqe9hEbP0pkEG/elkaiHegNGfNuEZhTDX8oglIBJYXnoSBgyYNUNNGrl9KpBSCb42FNQK1cEjv1x7+1ki6VXZjjBN2pyq7d8ZhKRhTbhEpaBrA87YWqGmXSemqHrImAVqCD4Q3Zul0lQJKVJZqHEl2YZxm5Uoa0h3JGVSdsGSgE0u7storD1l+MNPyW9s6TBaShIKFLK0pYCYopASSWLJTjmd8YqdaJck9WiWhQSACqalMxTtVqEJDvQczGg0fZBO66YpMoeim6ysVhamdi4Vik1wD5RVWfQwVWYUEuSSldC5egwAGEdMHsZSW4kNKf4Vm/5KP5I9+Kf4Nn/wCSj+SLFegpQdpalMzMsMX4Yj5coh+Ay/2cz84IP+U97RWZdhWERpCWqi5EkpONxAQobQpIDGIT7DZ0sesmAKDpNxKgc6hQqN0WUro5KU9Jid6k5nDs7O+CzdBBKCkX1pJqCzpPvJLBldxg5DgphYpZoicNrpUFNlQECDSrAJZStIvMcQrgQ7dksTiIcRoWTL9aYR/EB30jRaN6LGZKXPkkqRLIvLSo1B1dtnrTCKi0tmiZKTd0yqV0gmH15ctVQokipUAQFUarExaaT6STbZKlWa6ESkLExQvXlTFJTdS5ZISgDBLHByomsA0f0eFoTNmIlkplC9MIWpIArqw1HCEJhlywbqSlT3SFLVTOlHi6cqUZJ2Mqka0la6GOkdsUJKQmiCooBeqikOtQGQvJD/HyyZSMosbRKmTlO6WAZLksADVgxapqBA52h5yQ90KzulyGvPQsT6qsMoMRWdWeboVh6Kowy9RSxTurmJUNZunjh3xqdI23rDfOLJB2kBn4xj5ySL2YOGtxs4Ru9DSLIZl2bOMwM4SlCkPgA6iMNgjqwNS0Wmc2Np3aaKXr456RG2VZNHUaWQ7t6xwc/QwlaFaLSopJIIxF1eT6kx2qafEl8TjdNr2X8DK+kbucd6/ZGj6zRXvn8szwjt3RB9s/+4PpDzeQyf8AF/nvFeituEqVaJx9l2fBypbd7RkkdIZvX31Koo1fGut9Zi/0j1HUKRZ5yWUs3kEKKqTFXCHFXSzhxV90VGk+jE1ErriUlOtgxAOCiKuNo/p5+Iryi4qLO7D0YyzOSNbZ9PBM8zFqNwjk7UbIEnlF9K0rIX6s1B4seRrHz+TJCpaVddLcpSbvbc4UJusOeqIhMvXjV8SMY4caoqtmXVI7MHKWllfRs3k7SUkEgzUONV4E8hEZOkJS6JmIJxZ4xC0IbUB52wDqEOanEe1sEc6qo2cbm5naVkJVdM1IO/5nARG0aUkoDmYlthvHkIxK7OgF6h6UJPjEEykBWBqBrO3XFKuiNM3CdJySm/1iW20NK4Yxyz6RlLe6sUDlwRTOsYxSUtdAZOVQH8iFhZ0BV4BRoRV8eUVrrsLSNr+MSiWSp2xOAHNo8jTMg4TUYPUsOZo+yMOuXMJpdA4+EcMlwApJLPgD4Qa4tI0CbAlJoQxgiLIHqrGEhfZgR3wNKF+8OUcdzpuh82VLkuMKc6/OOLsoGsYfSE2XmI4UrxpzPhBsF0OIsqHctQZa6eEEnSUk0OGH0hBMpXl4IJSve+8K6C6JJs5LEXftBESlOXUAPPjA0yD7wjokHC8OcF4hdDsix1F5QI8mGRYQSe0ASKNsiqTZs198GlyK+tE5kNSQDSM1EszZQF4qQklWBSpNQ5aoKaNndZqvTSJiUl6tmBTnhEbVMcKPvK+p8IUsayhRmJJCkkXSAKFTh64EAKbW7EYR3xWVWMG7s+raP6d2US0JVo6zrISElRSApRAqo9jXjDX9uLCcdGSOCgP/AK4+RdsOQSXUUjMnye+LBJuhQKVBrrFqVD9oVx3xV2TZGt6VaYsM9A6myIkLBcqSXBDMzXRsjFzpoehiSp5IqlODBxqd9kdRadRQg6sCPrBcY3YZ6CLkwEoJemKFYCYjU+zAimRFlZNOTZMtUgTmQoEFiQFe6SjA7jGfXMBbsoRQAl+Lsak6n3cVLYpIWQhd4UY4Pmcd44QXCxorD0iVKC5aJix1gaYEdlKhqvDWKnnFaxWrtMPkBm2W0QlYUgueHKLaSW4VocDvDFJ2YQ0IYE8SxdSm8oioxwBrQ1oS5NGxgJ0pPDksQzFlBRYjWxOp6nbmYVnqe6KrKl/pEgFyGLJvYsX5tlFX1RQygSCnFqFzRvHZBcLF/b0otSDNSAJqQ6hXthyTvNeAS1XoCWiWAFGfMQogUSgYfvdalxTLVC+jLVdmJWGAVUgOwd0qDHHWWwZXCELVZ0iZMTUAKOBoxqGcRrTq5L7cmc6ea25bqny//VT/AMqf+ogakyCXM6YTmRKf/wCcxSdRWiqbdTAn6QWzWCbM/ugVDOgG68acI09VboidDyWb2YfrJh4S/wD9DEFT7MNc47rniYr7VoqdLIvIVXAjtCm0RwWJaUiYsEBRYPi4Du2UL1b6WD06LTRYQpabt5gz3veOLbK/eHrVpW9OKa3aoU5cKSeyWAFMU66vnCOi5gC07x8x51wSZYj1yXSEm6Lwd1JLEgM9BtwMYyk5O7NIpRCaOsdy7eqQGZ6DNobL5Q76DMZ7qqinGIq0dMp2DzHjHmVJTnK7NVGy2EHjxhz8Nmfs/wDMnxiI0fMw6vvETlfZjEr0cv7osvwqb7neI6NETcbg5jxgyPsFisvbI8Vbosfwmb7g5jxj34RMJwA3mHkfYCtvHZzjhfMCLU6EmfDz+0D/AAeaPc5nwh5H2Cw6nQyXqte6g+kE/BkZq5j+WLS55pHbj6+UdGnEZWjQ0vNfMfyxNOhpfvL5p/lh7qz74gS1hOMzuf6Ug049gF1aFRqUriR/JHfwlFOzMZsbySPk/dB+tUR2G3keBgwmK2fLxg049gFEaOlYG9xKh80wUaHlZH86oYK9o+f0jiiCGK+4CDJHsMGnRUr3VcFKH+6O/hsoalcST/uiSClPtk72MeM5OZgyR7AfPrbKulaPdUc9RIeuxqwnZpblSHLqa4KMqYFAJCnwDKWHcVIeNT0l0aVEzpYcs0xOsgAgKGbChAyEZFRG8RundGb2LbQ9iSFKFqlzQmWWIuquglnvqAdIbW/tJMFt+l0hBky6SnDgB1KukFNTg2+u1hCA0rOCCjrSUqLl2JJACXKiCSWAGOqEkgqUEpF5RwA1wAaHopJTPnqCpY6tCXIJJ7RLJfP2qAao2Z0FZj+pl8EkfJUVHR+zIs0tioFZLrINL2Q2CLI6URnzMZye5aWwGd0RkEhSLyGILOVJLVYhT04wG3dE0LB9QuSQCm4wLUCkl+ecMK02ga+8QJXSFGovCux2Rkrbo42eZ1d1qAit4FzqIxDvjlA1TXUBjgBr1PrAMP8ASm2pmlExOKQUq3Gqe8nnFJNmYKD0pr1PrNOEaxexk1uPSpbzJl0KvpSDeUzOAAhIyN4AA/DTKGtNIvE3AAohN2WSVBgSwTe/iYGtDDHVpmIEwOwmImLZyQpDAJKQkkoqo7CThR0FWK/eTMIU0xakBBvOCSVJJFEhyCFGtVNF2JuBRKIlpKqKeousQTVsMmpFbPtQE6YSHBxHAVi40jOchAcly1XqS7bhsyeAGQrNXfEy2KRpeicmXKlEzFJC5hcpcEhIe6Dtqo8RF+i3ygKTAOP3j5yLCrbE06OmHWe6M2rlp2PoM23yz7b/AMX3jOdMSJlnCkkG4sKNXLEFJ/1DlFRL0LNPtGGEaBXgpZY0IY/QwJWBsobNPYuNnzEapFmSbs0Ke8AlGDgEABNC57V4uQPWIrFSOi0x6TU8UqeLjQ+g1Sy61329UMwBzqr6RpexFjVpUkBg1N8evjyPvFYFNS8kcT9BEkpOfIHxjOxdyxM2BTJz4KI4PCZQ9HJ/L4mJiUdv5vAQWC5NKyMbyvOTxIzhkRvT94H1Hkkn6x663u8q/OACXpKcwOEd9ITn3HwgBmNrVyH3iKrSn4uLD6QWC4VVpyf8tYh1gyVygap6NZH5vCPCejUCdxUYYrhFrUNSeRjiVTDqTyMSlyidQ5/aGOqOQ5/aJKAdUs+0n8v3hS0aOWouSlQyZt+oxaISTl3+ETMtQHs8j4wXCwgizKDesMgCGpsPCCXFZq5Dwg0vrFOHAbUA3e7HhBuoVn8hAAiiQVCii3DwiXofxH5Q4iykEsWPFjweCGUr3hy1c4VwEPRNp5xBVmOZ5mLLqT73nnHFWNJOKuCiPrABTTLMc1cz4xUWnQN9RUsXzm908x63ExrzY0/F+Y+MR9CRt/MfGGmJowydAyiSLigRqJPjDEnQtwdh0vixNd8bI6MQagV5nnAvQiMFcFJB7w31h3CxkV6MXmecBOjlbY2qpTAukEDI15EfWOyUy1hxuqz8RqgAwytHKyMRNgVkY33oyY4ZAGoeeEFwMF6KWIKSQcaRWT7EtLslSh+7UedkfTeqyHdHDJ+HugTEfNLFaJss9lKxuQa+ctpixXbrTMp1Uw7kK+ZADbS0bgIOsAf1gZnITipP5hui87Jyoymi9GEEqmA3zrIugbicS5NfvFzK0ds74s5dpSRnur8o8lF4khKxuBHcQ0S2OwonR2YggsyRDAlzPcUd7D/d9IKlx7J7j9YLjFRJ2E8I6LMrIDeYMVF9f5THbxpQ8j4QrgA9F+JtwHzgc5KU49o5fU5YGGws5NwMK2yUXvAglqh28nwhgcEpw5LDJOPOPCzJfBR31MeRaSaFk/MQwlAPtA8fvABAzANd3cB8iDHL/wASjwHhE5kpIygCk5VhAS3PzaIqUB/3Hxjgs6jjSPCSkaxzaGAvTEAHbqggFcRuAghUjYdxf6RGmpJ3t94AOMPdjrqGuOXVYMeIMRVJ+AcmgAdTaG1HkS/hBk2kNgrl9oApIzO3btgaS2D/AF8P6RBQ96QGq/I+EBnTnqkkb0k8oiia9PPmkdCxTHX585QATlTQkAXT84n6WPdPLOIOMo4rdnAAUWl/ZPIfUxLrT7vO74wMeeUdJPniflAATrFe6Of2jwnKyGeP2gZIAenLd54xIO1ftAB0zFnUOf2jhmK2cj4xMDB4klPPk3loABXl59332xwy1nFZG4J8DDXVFvOoiIlIwpAAr6PmtXP6ACI+ifErgpXyBhgH566x0JJ+0MQD0dOsPkcX5xzqpZ9lPIQyiSmmva8TCBq3eTvguAqmQBglPnuMSFjBpdR+UH7Q0Swrh84kVCALCqNHI9xP5QIKizIGCQNyR9BEzPGrV9I8LQ+p+MIAgyjvPZ4RDrVe6AecQSqYTikZUxgGHKTHCjZAurWa9ZyGqI+juarVr17/AAgAmogZQJS0+8BxjqbKjWCc3JgiLOgeyPO+ABYz5Y9pzseFETB7qjnTXFoQB4eeEAWlzSGIXnAKFZfezfWFzY1H1ab6w8E3ancIM4rABVmyEesnilj94kiSjUtQOV532V1VixKhwgUxSC2uo1Yeaw7hYAqwEagviR3OR3xwyPgHnughYGhI74H6Qqtb2T0PnCARIyz7p7vGOKQfdPMc8YEq1lOKG1407o4LW+vbX7eaQAFO493jEL+w8j94iqZtfnAF2sDbwgA//9k="
                 }
                 );
        }
    }
}

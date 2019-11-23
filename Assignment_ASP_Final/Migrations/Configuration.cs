using Assignment_ASP_Final.Models;

namespace Assignment_ASP_Final.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment_ASP_Final.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Assignment_ASP_Final.Models.ApplicationDbContext";
        }

        protected override void Seed(Assignment_ASP_Final.Models.ApplicationDbContext context)
        {
            context.Categories.AddOrUpdate(x => x.Id,
                new Category() { Id = 1, Name = "Đồ bộ bé gái" },
                new Category() { Id = 2, Name = "Váy đầm bé gái" },
                new Category() { Id = 3, Name = "Đồ bơi bé gái" },
                new Category() { Id = 4, Name = "Áo bé gái" },
                new Category() { Id = 5, Name = "Quần bé gái" },
                new Category() { Id = 6, Name = "Giày bé gái" },
                new Category() { Id = 7, Name = "Đồ bộ bé trai" },
                new Category() { Id = 8, Name = "Đồ bơi bé trai" },
                new Category() { Id = 9, Name = "Áo bé trai" },
                new Category() { Id = 10, Name = "Quần bé trai" },
                new Category() { Id = 11, Name = "Giày bé trai" },
                new Category() { Id = 12, Name = "Nón" },
                new Category() { Id = 13, Name = "Balo-Túi sách" });
            context.Products.AddOrUpdate(x => x.Id,
                new Product() { Id = 1, Name = "Sét áo sơ mi kèm chân váy", CategoryId = 1, Description = "Sét áo sơ mi kèm chân váy cho bé từ 12 đến 14 tuổi", Quantity = 100, Discount = 15, UnitPrice = 150000, Image = "https://www.bexinhshop.vn/image/data/18-11-2019/BOAODAICHANVAYSTOPTRANG.jpg" },
                new Product() { Id = 2, Name = "Sét áo sơ mi kèm chân váy", CategoryId = 1, Description = "Sét áo sơ mi kèm chân váy cho bé từ 12 đến 14 tuổi", Quantity = 100, Discount = 15, UnitPrice = 350000, Image = "https://www.bexinhshop.vn/image/data/12-11-2019/setsomyvaycaro.jpg" },
                new Product() { Id = 3, Name = "Set áo kate nơ kèm chân váy", CategoryId = 1, Description = "Set áo kate nơ kèm chân váy cho bé từ 12 đến 14 tuổi", Quantity = 100, Discount = 20, UnitPrice = 250000, Image = "https://www.bexinhshop.vn/image/data/12-11-2019/setsomyvaytrang.jpg" },
                new Product() { Id = 4, Name = "Bộ dài tay báo hồng đắp đôi cánh", CategoryId = 1, Description = "Bộ dài tay báo hồng đắp đôi cánh cho bé từ 12 đến 14 tuổi", Quantity = 100, Discount = 0, UnitPrice = 450000, Image = "https://www.bexinhshop.vn/image/data/18-11-2019/setdaitaylovecauvonghong.jpg" },
                new Product() { Id = 5, Name = "Set bơi bèo kèm nón", CategoryId = 3, Description = "Set bơi bèo kèm nón dễ thương cho bé gái 3 - 10 tuổi. Chất thun poly co giãn mạnh", Quantity = 100, Discount = 35, UnitPrice = 550000, Image = "https://www.bexinhshop.vn/image/data/16-4-2019/setboido.jpg" },
                new Product() { Id = 6, Name = "Set bơi người nhện", CategoryId = 8, Description = "Set bơi người nhện dễ thương cho bé trai 3 - 10 tuổi. Chất thun poly co giản mạnh thoãi mái cho bé.", Quantity = 100, Discount = 15, UnitPrice = 650000, Image = "https://www.bexinhshop.vn/image/data/25-4-2019/SETBOINHENDENDO.jpg" },
                new Product() { Id = 7, Name = "Nón vành tròn tai Tuần Lộc", CategoryId = 12, Description = "Nón vành tròn tai Tuần Lộc cực dễ thương cho bé - Thiết kế vành tròn cá tính, dễ thương cho bé, thấm hút mồ hôi cực tốt", Quantity = 100, Discount = 25, UnitPrice = 150000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/non500.jpg" },
                new Product() { Id = 8, Name = "Túi đeo chéo VỊT VÀNG", CategoryId = 13, Description = "Túi đeo chéo VỊT VÀNG dễ thương cho bé - Kích thước: - Thiết kế 1 ngăn có khóa kéo thuận tiện cho bé tự đựng đồ lặt vặt... ^^", Quantity = 100, Discount = 55, UnitPrice = 1150000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/tuideocheo21.jpg" },
                new Product() { Id = 9, Name = "Túi đeo chéo Gấu dễ thương", CategoryId = 13, Description = "Túi đeo chéo Gấu dễ thương cho bé - Thiết kế khóa kéo ngang style nhỏ nhắn , xinh sắn ,chắc chắn cực đáng iu", Quantity = 100, Discount = 15, UnitPrice = 1250000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/tuideocheo16.jpg" },
                new Product() { Id = 10, Name = "Nón vành tròn tai thỏ mặt cười HỒNG", CategoryId = 12, Description = "Nón vành tròn tai thỏ mặt cười HỒNG dễ thương cho bé - Thiết kế vành tròn cá tính, dễ thương cho bé", Quantity = 100, Discount = 25, UnitPrice = 1350000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/non205.jpg" },
                new Product() { Id = 11, Name = "Set áo thun chữ B", CategoryId = 7, Description = "Sét áo thun chữ B", Quantity = 100, Discount = 15, UnitPrice = 1450000, Image = "https://www.bexinhshop.vn/image/data/18-11-2019/SETJEASNCHUBxanh.jpg" },
                new Product() { Id = 12, Name = "Set áo nón đắp túi cho bé nam", CategoryId = 7, Description = "Set áo nón đắp túi dễ thương cho bé ngày mưa. Nguyên bộ chất thun cotton 4c co giãn, mềm mát", Quantity = 100, Discount = 35, UnitPrice = 1550000, Image = "https://www.bexinhshop.vn/image/data/8-11-2019/boaonondaptuihong.jpg" },
                new Product() { Id = 13, Name = "Sét áo sơ mi kèm chân váy", CategoryId = 4, Description = "Sét áo sơ mi kèm chân váy cho bé từ 12 đến 14 tuổi", Quantity = 100, Discount = 15, UnitPrice = 150000, Image = "https://www.bexinhshop.vn/image/data/18-11-2019/BOAODAICHANVAYSTOPTRANG.jpg" },
                new Product() { Id = 14, Name = "Bộ thun phối màu Buery", CategoryId = 4, Description = "Bộ thun phối màu Buery", Quantity = 100, Discount = 15, UnitPrice = 350000, Image = "https://www.bexinhshop.vn/image/data/4-11-2019/bodaitaythethaobuerydo.jpg" },
                new Product() { Id = 15, Name = "Set áo kate nơ kèm chân váy", CategoryId = 5, Description = "Set áo kate nơ kèm chân váy cho bé từ 12 đến 14 tuổi", Quantity = 100, Discount = 20, UnitPrice = 250000, Image = "https://www.bexinhshop.vn/image/data/12-11-2019/setsomyvaytrang.jpg" },
                new Product() { Id = 16, Name = "Bộ dài tay báo hồng đắp đôi cánh", CategoryId = 5, Description = "Bộ dài tay báo hồng đắp đôi cánh cho bé từ 12 đến 14 tuổi", Quantity = 100, Discount = 0, UnitPrice = 450000, Image = "https://www.bexinhshop.vn/image/data/18-11-2019/setdaitaylovecauvonghong.jpg" },
                new Product() { Id = 17, Name = "Set bơi bèo kèm nón", CategoryId = 3, Description = "Set bơi bèo kèm nón dễ thương cho bé gái 3 - 10 tuổi. Chất thun poly co giãn mạnh", Quantity = 100, Discount = 35, UnitPrice = 550000, Image = "https://www.bexinhshop.vn/image/data/16-4-2019/setboido.jpg" },
                new Product() { Id = 18, Name = "Set phao bơi cướp biển", CategoryId = 8, Description = "Set phao bơi cướp biển", Quantity = 100, Discount = 15, UnitPrice = 650000, Image = "https://www.bexinhshop.vn/image/data/25-4-2019/SETBOINHENDENDO.jpg" },
                new Product() { Id = 19, Name = "Nón vành tròn tai Tuần Lộc", CategoryId = 12, Description = "Nón vành tròn tai Tuần Lộc cực dễ thương cho bé ", Quantity = 100, Discount = 25, UnitPrice = 150000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/non3D105.jpg" },
                new Product() { Id = 20, Name = "Túi đeo chéo VỊT VÀNG", CategoryId = 13, Description = "Túi đeo chéo VỊT VÀNG dễ thương cho bé - Thiết kế khóa kéo ngang style nhỏ nhắn , xinh sắn ,chắc chắn cực đáng iu.", Quantity = 100, Discount = 55, UnitPrice = 1150000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/tuideocheo21.jpg" },
                new Product() { Id = 21, Name = "Túi đeo chéo Gấu dễ thương", CategoryId = 13, Description = "Túi đeo chéo Gấu dễ thương cho bé - Thiết kế khóa kéo ngang style nhỏ nhắn , xinh sắn ,chắc chắn cực đáng iu.", Quantity = 100, Discount = 15, UnitPrice = 1250000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/tuideocheo16.jpg" },
                new Product() { Id = 22, Name = "Nón vành tròn tai thỏ mặt cười HỒNG", CategoryId = 12, Description = "Nón vành tròn tai thỏ mặt cười HỒNG dễ thương cho bé - Thiết kế vành tròn cá tính, dễ thương cho bé", Quantity = 100, Discount = 25, UnitPrice = 1350000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/non505.jpg" },
                new Product() { Id = 23, Name = "Sét Áo thun gucc", CategoryId = 7, Description = "Set Đồ bộ gucc", Quantity = 100, Discount = 15, UnitPrice = 1450000, Image = "https://www.bexinhshop.vn/image/data/18-11-2019/setjeassndaiguuden_1.jpg" },
                new Product() { Id = 24, Name = "Set áo nón đắp túi cho bé nam", CategoryId = 7, Description = "Set áo nón đắp túi dễ thương cho bé ngày mưa", Quantity = 100, Discount = 35, UnitPrice = 1550000, Image = "https://www.bexinhshop.vn/image/data/8-11-2019/boaonondaptuihong.jpg" },
                new Product() { Id = 25, Name = "Sét áo sơ mi kèm chân váy", CategoryId = 1, Description = "Sét áo sơ mi kèm chân váy cho bé từ 12 đến 14 tuổi", Quantity = 100, Discount = 15, UnitPrice = 150000, Image = "https://www.bexinhshop.vn/image/data/18-11-2019/BOAODAICHANVAYSTOPTRANG.jpg" },
                new Product() { Id = 26, Name = "Sét bơi liền in thỏ", CategoryId = 3, Description = "Sét bơi liền in thỏ", Quantity = 100, Discount = 15, UnitPrice = 350000, Image = "https://www.bexinhshop.vn/image/data/do-boi-tre-em-2019/do-boi-be-gai/SETBOITHOHONG.jpg" },
                new Product() { Id = 27, Name = "Quần kaki dài", CategoryId = 10, Description = "Quần kaki dài", Quantity = 100, Discount = 20, UnitPrice = 250000, Image = "https://www.bexinhshop.vn/image/data/18-11-2019/quankakituihopcam.jpg" },
                new Product() { Id = 28, Name ="Quần da cá", CategoryId = 10, Description = "Quần da cá", Quantity = 100, Discount = 0, UnitPrice = 450000, Image = "https://www.bexinhshop.vn/image/data/15-10-2019/quandacaphoilinh1.jpg" },
                new Product() { Id = 29, Name = "Áo thun cổ trụ thêu hoa", CategoryId = 9, Description = "Áo thun cổ trụ thêu hoa", Quantity = 100, Discount = 35, UnitPrice = 550000, Image = "https://www.bexinhshop.vn/image/data/18-11-2019/AOTHUNHOAVANxanh.jpg" },
                new Product() { Id = 30, Name = "Áo khoác gió NY", CategoryId = 9, Description = "Áo khoác gió NY", Quantity = 100, Discount = 15, UnitPrice = 650000, Image = "https://www.bexinhshop.vn/image/data/18-11-2019/AOKHOACGIONYDO.jpg" },
                new Product() { Id = 31, Name = "Nón vành tròn tai Tuần Lộc", CategoryId = 12, Description = "Nón vành tròn tai Tuần Lộc cực dễ thương cho bé - Thiết kế vành tròn cá tính, dễ thương cho bé, Nón vành trong cực ngầu cho bé đi học", Quantity = 100, Discount = 25, UnitPrice = 150000, Image = "https://www.bexinhshop.vn/image/data/08-08-2014/gi%C3%A0y/nonN14Y.jpg" },
                new Product() { Id = 32, Name = "Túi đeo chéo VỊT VÀNG", CategoryId = 13, Description = "Túi đeo chéo VỊT VÀNG dễ thương cho bé - Thiết kế khóa kéo ngang style nhỏ nhắn , xinh sắn ,chắc chắn cực đáng iu.", Quantity = 100, Discount = 55, UnitPrice = 1150000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/tuideocheo21.jpg" },
                new Product() { Id = 33, Name = "Túi đeo chéo Gấu dễ thương", CategoryId = 13, Description = "Túi đeo chéo Gấu dễ thương cho bé - Thiết kế khóa kéo ngang style nhỏ nhắn , xinh sắn ,chắc chắn cực đáng iu.", Quantity = 100, Discount = 15, UnitPrice = 1250000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/tuideocheo16.jpg" },
                new Product() { Id = 34, Name = "Nón vành tròn tai thỏ mặt cười HỒNG", CategoryId = 12, Description = "Nón vành tròn tai thỏ mặt cười HỒNG dễ thương cho bé - Thiết kế vành tròn cá tính, dễ thương cho bé, Nón vành trong cực ngầu cho bé đi học", Quantity = 100, Discount = 25, UnitPrice = 1350000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/non505.jpg" },
                new Product() { Id = 35, Name = "Set pijama", CategoryId = 1, Description = "Set pijama họa tiết hoạt hình Cookie dễ thương cho bé trai & bé gái. Chất thun cotton 4c co giãn, mềm mát", Quantity = 100, Discount = 15, UnitPrice = 1450000, Image = "https://www.bexinhshop.vn/image/data/14-11-2019/PIJAMATHOXANHNGOC.jpg" },
                new Product() { Id = 36, Name = "Set áo nón đắp túi cho bé nam", CategoryId = 7, Description = "Set áo nón đắp túi dễ thương cho bé ngày mưa. Nguyên bộ chất thun cotton 4c co giãn, mềm mát, thấm hút mồ hôi tốt thoãi mái cho bé khi mang.", Quantity = 100, Discount = 35, UnitPrice = 1550000, Image = "https://www.bexinhshop.vn/image/data/8-11-2019/boaonondaptuihong.jpg" },
                new Product() { Id = 37, Name = "Giày thể thao cho bé gái", CategoryId = 6, Description = "Giày thể thao cho bé gái từ 10 đến 12 tuổi", Quantity = 50, Discount = 0, UnitPrice = 1550000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/giaythethao5010.jpg" },
                new Product() { Id = 38, Name = "Dầm tiểu thư cho bé gái", CategoryId = 2, Description = "Đầm tiểu thư cho bé gái từ 10 đến 12 tuổi", Quantity = 50, Discount = 0, UnitPrice = 1550000, Image = "https://www.bexinhshop.vn/image/data/3-10-2019/damvaonxopcanhtienxanh.jpg" },
                new Product() { Id = 39, Name = "Giày thể thao gucci", CategoryId = 11, Description = "Giày thể thao gucci", Quantity = 50, Discount = 0, UnitPrice = 1550000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/giaythethao5207.jpg" },
                new Product() { Id = 40, Name = "Giày boot đính nơ", CategoryId = 11, Description = "Giày boot đính nơ", Quantity = 50, Discount = 0, UnitPrice = 1550000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/giayboot1013.jpg" },
                new Product() { Id = 41, Name = "Giày thể thao", CategoryId = 11, Description = "Giày thể thao", Quantity = 50, Discount = 0, UnitPrice = 1550000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/giaythethao5010.jpg" },
                new Product() { Id = 42, Name = "Giày thể thao đèn chớp", CategoryId = 11, Description = "Giày thể thao đèn chớp", Quantity = 50, Discount = 0, UnitPrice = 1550000, Image = "https://www.bexinhshop.vn/image/data/1-10-2016/M%E1%BB%9AI/giaythethao3012.jpg" },
                new Product() { Id = 43, Name = "GIày thể thao cổ chun", CategoryId = 11, Description = "GIày thể thao cổ chun", Quantity = 50, Discount = 0, UnitPrice = 1550000, Image = "https://www.bexinhshop.vn/image/data/1-10-2015/M%E1%BB%9AI/giaythethao1104.jpg" });
        }
    }
}

import { Component } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { Manufacturer } from './services/manufacturer';
import { ManufacturerService } from './services/manufacturer.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  items: MenuItem[] = [];
  products: Manufacturer[] = [];
  status = false;
  brands:any = [];
  contents:any =[];
	
	responsiveOptions;

	constructor(private productService: ManufacturerService) { 
		this.responsiveOptions = [
            {
                breakpoint: '1024px',
                numVisible: 3,
                numScroll: 3
            },
            {
                breakpoint: '768px',
                numVisible: 2,
                numScroll: 2
            },
            {
                breakpoint: '560px',
                numVisible: 1,
                numScroll: 1
            }
        ];
	}

  ngOnInit() {
    this.productService.getProductsSmall().then(products => {
			this.products = products;
		});

    this.items = [
        {
            label:'Screen',
            icon:'pi pi-fw pi-file',
        },
        {
            label:'PC',
            icon:'pi pi-fw pi-pencil',
        },
        {
            label:'Laptop',
            icon:'pi pi-fw pi-user',
        },
        {
            label:'Keyboard',
            icon:'pi pi-fw pi-calendar',
        },
    ];

    this.brands = [
      {img: "https://www.freepnglogos.com/uploads/apple-logo-png/apple-logo-png-dallas-shootings-don-add-are-speech-zones-used-4.png", name: "MacBook"},
      {img: "https://upload.wikimedia.org/wikipedia/commons/6/6f/HP_logo_630x630.png", name: "HP"},
      {img: "https://www.freepnglogos.com/uploads/dell-png-logo/dell-png-logo-0.png", name: "Dell"},
      {img: "https://www.pngmart.com/files/22/Asus-Logo-Transparent-PNG.png", name: "Asus"},
      {img: "https://logos-world.net/wp-content/uploads/2022/11/Acer-Logo.png", name: "Acer"},
      {img: "https://storage-asset.msi.com/global/picture/image/feature/nb/AMD/Bravo15-5000/bravo-logo.png", name: "MSI"},
      {img: "https://logos-download.com/wp-content/uploads/2016/05/Xiaomi_Logo_2021.png", name: "Mi NoteBook"},
      {img: "https://p.kindpng.com/picc/s/349-3493264_high-resolution-leica-logo-hd-png-download.png", name: "Lenovo"},
      {img: "https://seeklogo.com/images/H/Huawei-logo-A8C7CBCAA8-seeklogo.com.png", name: "Huawei"},
      {img: "https://www.freepnglogos.com/uploads/lg-logo-png/lg-logo-logo-png-transparent-svg-vector-bie-supply-0.png", name: "LG"},
      {img: "https://download.logo.wine/logo/ThinkPad/ThinkPad-Logo.wine.png", name: "ThinkPad"},
      {img: "https://i.pinimg.com/736x/ba/45/24/ba452436d152a2a216c3058f7b2a7032--surface-pro--future-videos.jpg", name: "Surface"},
    ]

    this.contents = [
    {img: "https://cellphones.com.vn/sforum/wp-content/uploads/2022/02/MacBook-Pro-2020-cover.jpg",
    name: "MacBook Air M1 2020",
    body: "Laptop Apple MacBook Air M1 2020 thuộc dòng laptop cao cấp sang trọng có cấu hình mạnh mẽ, chinh phục được các tính năng văn phòng lẫn đồ hoạ mà bạn mong muốn, thời lượng pin dài, thiết kế mỏng nhẹ sẽ đáp ứng tốt các nhu cầu làm việc của bạn.", price: 1000},

    {img: "https://9to5mac.com/wp-content/uploads/sites/6/2021/10/MacBook-Pro-2021.jpg?quality=82&strip=all&w=1024",
    name: "MacBook Air M2",
    body: "Sau 14 năm, ba lần sửa đổi và hai kiến trúc bộ vi xử lý khác nhau, kiểu dáng mỏng dần mang tính biểu tượng của MacBook Air đã đi vào lịch sử. Thay vào đó là một chiếc MacBook Air M2 với thiết kế hoàn toàn mới, độ dày không thay đổi tương tự như MacBook Pro, đánh bật mọi rào cản với con chip Apple M2 đầy mạnh mẽ.", price: 2000},

    {img: "https://cellphones.com.vn/sforum/wp-content/uploads/2022/02/MacBook-Pro-2020-cover.jpg",
    name :"MacBook Pro 14 inch",
    body: "Apple đã âm thầm tung ra thế hệ MacBook Pro 14 inch M2 Pro 2023 hoàn toàn mới, hứa hẹn hiệu suất cao hơn so với MacBook Pro đợt trước, có khả năng xử lý mượt mà các tác vụ khắt khe của người dùng chuyên nghiệp.", price: 3000},

    {img: "https://cdn.tgdd.vn/Files/2021/06/27/1363660/giai-thich-ten-goi-cua-cac-dong-laptop-hp-va-dong--3.png",
    name: "HP 15s fq5078TTU i5 (6K798PA)",
    body: "Thiết kế thanh lịch, tao nhã tạo nên vẻ đẹp quyến rũ của chiếc laptop HP 15s fq5078TTU i5 (6K798PA), sở hữu dòng chip Intel thế hệ 12 sẵn sàng cân đối mọi tác vụ của laptop học tập - văn phòng phù hợp với sinh viên, học sinh, nhân viên văn phòng. Laptop Acer Aspire 7 Gaming A715 42G R05G (NH.QAYSV.007) sở hữu phong cách thiết kế độc đáo, thời thượng cùng hiệu năng mạnh mẽ, đáp ứng tối đa mọi nhu cầu của người dùng từ cơ bản đến nâng cao.", price: 1500},

    {img: "https://cdn2.cellphones.com.vn/x,webp,q100/media/wysiwyg/laptop/HP/laptop-hp-1.jpg",
    name: "HP Pavilion 15 eg2056TU i5 (6K786PA)",
    body: "Laptop HP Pavilion 15 eg2056TU i5 (6K786PA) là phiên bản laptop học tập - văn phòng sở hữu hiệu năng vượt trội đến từ con chip Gen 12 mạnh mẽ cùng phong cách thiết kế đơn giản, sang trọng, đáp ứng tốt mọi nhu cầu sử dụng thiết yếu hằng ngày. ", price: 1000},

    {img: "https://bizweb.dktcdn.net/100/033/226/files/0000-6461987cv1d.jpg?v=1640865061245",
    name: "HP VICTUS 15 fa0111TX i5 (7C0R4PA)",
    body: "Laptop HP VICTUS 15 fa0111TX i5 (7C0R4PA) hứa hẹn mang đến trải nghiệm làm việc và giải trí tuyệt vời nhờ bộ vi xử lý Intel Core i5 12500H mạnh mẽ, card đồ họa rời đến từ NVIDIA và màn hình 144 Hz siêu mượt mà.", price: 3000},

    {img: "https://maytinhkimlong.com/uploads/product/640%20IMG/laptop_hp_15_dy2091wm_491d1ua_bc%20-%20Copy%201.jpg",
    name: "Laptop demo",
    body: "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.", price: 1000},

    {img: "https://cdn.tgdd.vn/Products/Images/44/305456/surface-pro-9-i5-glr-xam-1.jpg",
    name: "Surface Pro 9 i5 1235U",
    body: "Laptop Surface Pro 9 i5 1235U là một chiếc máy tính 2 trong 1 kết hợp giữa laptop và máy tính bảng từ Microsoft, mang trong mình những thông số cấu hình ấn tượng nhằm đảm bảo vận hành mượt mà mọi tác vụ học tập, văn phòng.", price: 2000},

    {img: "https://cdn.tgdd.vn/Products/Images/44/305459/surface-pro-9-i7-glr-2.jpg",
    name: "Surface Pro 9 i7 1255U",
    body: "Laptop Surface Pro 9 i7 1255U không chỉ có cấu hình mạnh mẽ mà còn được thiết kế với ngoại hình hiện đại, gọn nhẹ để người dùng dễ dàng mang theo. Thiết bị đặc biệt phù hợp cho các chuyên gia và sinh viên cần xử lý các tác vụ yêu cầu hiệu suất cao và có nhu cầu giải trí mọi lúc, mọi nơi.", price: 4000},

    ]
  }
}

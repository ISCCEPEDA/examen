import { Component, OnInit } from '@angular/core';
import {MenuItem} from 'primeng/api';
import { MenuService } from '../../services/menu.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {
  items: MenuItem[] = [];

  get contador(): number {
    return this.menuService.contadorProducto;
  }
  set contador(value: number) {
    this.menuService.contadorProducto = value;
  }

  constructor(private menuService: MenuService) { }

  ngOnInit(): void {
    this.items = [
      {
        label:'Inicio',
        icon: 'pi pi-fw pi-home',
        routerLink: 'QuienesSomos/Inicio'
      },
      {
        label:'Menú',
        icon:'pi pi-fw pi-book',
        items:[            
            {
              label:'Desayunos',
              routerLink: 'Platillos/Productos/1CD3336F-ABD9-4F38-8166-C51D3CE02588'                
            },
            {
              label:'Comidas',
              routerLink: 'Platillos/Productos/F83A5001-2C3A-4B52-9363-BDB85447769B'                
            },
            {
              label:'Cenas',
              routerLink: 'Platillos/Productos/C40215F4-901A-443A-824A-CF63C64FAB73'                
            },
            {
              label:'Postres',
              routerLink: 'Platillos/Productos/9A30AF3F-6F59-4271-803E-BFD7ADB995D7'                
            },
            {
              label:'Bebidas',
              routerLink: 'Platillos/Productos/F42F94FC-BEC7-4F5D-92AC-6BC0427A4BDB'                
            },                        

        ]
      },
      {
        label:'Contacto',
        icon: 'pi pi-fw pi-wallet',
        routerLink: 'Contacto/Inicio'
      },            
    ]
  }

}

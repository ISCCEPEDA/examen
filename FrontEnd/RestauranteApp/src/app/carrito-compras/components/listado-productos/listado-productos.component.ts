import { Component, OnInit } from '@angular/core';
import { Product } from '../../interfaces/ProductoModel';
import {SelectItem} from 'primeng/api';
import { PrimeNGConfig } from 'primeng/api';
import { ProductService } from '../../services/product.service';
import { ActivatedRoute } from '@angular/router';
import { MenuService } from 'src/app/shared/services/menu.service';

@Component({
  selector: 'app-listado-productos',
  templateUrl: './listado-productos.component.html',
  styleUrls: ['./listado-productos.component.css']
})
export class ListadoProductosComponent implements OnInit {
  products: Product[] = [];
  sortOptions: SelectItem[] = [];
  sortOrder!: number;
  sortField!: string;
  menu!: string;
  //total: number = 0;

  get total(): number {
    return this.menuService.total;
  }
  set total(value: number) {
    this.menuService.total = value;
  }

  constructor(
    private productService: ProductService, 
    private primengConfig: PrimeNGConfig,
    private activatedRoute: ActivatedRoute,
    private menuService: MenuService
    ) { }

  ngOnInit(): void {

    this.activatedRoute.params.subscribe((params) => {
//      console.log(params.id);
      this.productService.obtenerPorIdCategoria(params.id)
      .subscribe(producto => {
        console.log("dd");
        console.log(producto);
        this.products = producto.listado;
        this.menu = producto.listado[0].descripcion;
      })
    });

    this.primengConfig.ripple = true;    
  }

  cargarAlCarrito(precio: number): void {
    this.menuService.total += precio;
    this.menuService.contadorProducto += 1;
  }

}

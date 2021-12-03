import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CarritoComprasRoutingModule } from './carrito-compras-routing.module';
import { ProductosComponent } from './pages/productos/productos.component';
import { ListadoProductosComponent } from './components/listado-productos/listado-productos.component';
import { PrimeNgModule } from '../prime-ng/prime-ng.module';


@NgModule({
  declarations: [
    ProductosComponent,
    ListadoProductosComponent
  ],
  imports: [
    CommonModule,
    CarritoComprasRoutingModule,
    PrimeNgModule
  ]
})
export class CarritoComprasModule { }

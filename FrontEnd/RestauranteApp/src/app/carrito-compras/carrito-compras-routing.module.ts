import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductosComponent } from './pages/productos/productos.component';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: 'Productos/:id',
        component: ProductosComponent
      },
      {
        path: '**',
        redirectTo: 'Productos'
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CarritoComprasRoutingModule { }

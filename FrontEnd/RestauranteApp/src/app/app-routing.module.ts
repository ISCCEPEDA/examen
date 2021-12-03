import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ErrorPageComponent } from './shared/pages/error-page/error-page.component';

const routes: Routes = [
  {
    path: 'QuienesSomos',
    loadChildren: () => import('./quienes-somos/quienes-somos.module').then(m => m.QuienesSomosModule)
  },
  {
    path: 'Contacto',
    loadChildren: () => import('./contacto/contacto.module').then(m => m.ContactoModule)
  },  
  {
    path: 'Platillos',
    loadChildren: () => import('./carrito-compras/carrito-compras.module').then(m => m.CarritoComprasModule)
  },    
  {
    path: '404',
    component: ErrorPageComponent
  },
  {
    path: '**',
    //component: ErrorPageComponent
    redirectTo: '404'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

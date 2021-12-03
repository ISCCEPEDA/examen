import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ContactoRoutingModule } from './contacto-routing.module';
import { InicioComponent } from './pages/inicio/inicio.component';
import { PrimeNgModule } from '../prime-ng/prime-ng.module';



@NgModule({
  declarations: [
    InicioComponent
  ],
  imports: [
    CommonModule,
    ContactoRoutingModule,
    PrimeNgModule
  ]
})
export class ContactoModule { }

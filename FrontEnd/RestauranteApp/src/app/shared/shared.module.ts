import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MenuComponent } from './components/menu/menu.component';
import { ErrorPageComponent } from './pages/error-page/error-page.component';
import { PrimeNgModule } from '../prime-ng/prime-ng.module';



@NgModule({
  declarations: [
    MenuComponent,
    ErrorPageComponent
  ],
  exports:[
    MenuComponent
  ],  
  imports: [
    CommonModule,
    PrimeNgModule
  ]
})
export class SharedModule { }

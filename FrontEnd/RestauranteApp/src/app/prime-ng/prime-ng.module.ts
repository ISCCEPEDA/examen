import { NgModule } from '@angular/core';
//import { CommonModule } from '@angular/common';

import { ButtonModule } from 'primeng/button';
import {MenubarModule} from 'primeng/menubar';
import {DividerModule} from 'primeng/divider';
import {PanelModule} from 'primeng/panel';
import {TableModule} from 'primeng/table';
import {CardModule} from 'primeng/card';
import {DataViewModule} from 'primeng/dataview';
import {BadgeModule} from 'primeng/badge';

@NgModule({
  declarations: [],
  exports:[
    ButtonModule,
    MenubarModule,
    PanelModule,
    TableModule,
    DividerModule,
    CardModule,
    DataViewModule,
    BadgeModule
  ]  
  // imports: [
  //   CommonModule
  // ]
})
export class PrimeNgModule { }

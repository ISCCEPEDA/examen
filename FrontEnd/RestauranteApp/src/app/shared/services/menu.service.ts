import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MenuService {
  private _ContadorProductos: number = 0;
  private _total: number = 0;

  get contadorProducto(){
    return this._ContadorProductos;
  }

  set contadorProducto(value: number){
    this._ContadorProductos = value;
  }

  get total(){
    return this._total;
  }

  set total(value: number){
    this._total = value;
  }

  constructor() { }
}

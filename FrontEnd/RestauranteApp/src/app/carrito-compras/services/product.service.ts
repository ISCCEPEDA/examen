import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Product } from '../interfaces/ProductoModel';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) { }
  private apiURL = environment.apiURL + 'Restaurante';

  public obtenerPorIdCategoria(id: string): Observable<any>{
    return this.http.get<any>(`${this.apiURL}/PlatillosPorCategoria/${id}`);
  }

}

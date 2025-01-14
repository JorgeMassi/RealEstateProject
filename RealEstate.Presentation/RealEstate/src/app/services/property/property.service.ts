import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment.development';
import { Property } from '../../models/property/property';

@Injectable({
  providedIn: 'root'
})
export class PropertyService {
  private url: string;

  constructor(private http: HttpClient) {
    this.url = environment.apiUrl + '/Property';
  }

  public getAll(): Observable<Property[]> {
    return this.http.get<Property[]>(this.url);
  }

  
  public create(apt: Property): Observable<Property> {
    return this.http.post<Property>(this.url, apt); 
  }
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ClientService {
  constructor(private http: HttpClient) { }

  baseUrl = 'https://localhost:7208/api/'

  public getAll<T>(endpoint: string): undefined {
    this.http.get<T>(this.baseUrl + endpoint).subscribe((data) => { return data; });
  };
}

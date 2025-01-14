import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../../environments/environment.development';
import { User } from '../../../models/roles/user/user';


@Injectable({
  providedIn: 'root'
})
export class UserService {
  private url: string;

  constructor(private http: HttpClient) {
    this.url = environment.apiUrl + '/User';
  }

  private getToken(): string | null {
    return localStorage.getItem('token');
  }

  
  private get httpHeaders(): HttpHeaders {
    const token = this.getToken();
    return new HttpHeaders({
      Authorization: token ? `Bearer ${token}` : '' 
    });
  }

  
  public getAll(): Observable<User[]> {
    console.log(this.httpHeaders); 
    return this.http.get<User[]>(this.url, { headers: this.httpHeaders });
  }
}

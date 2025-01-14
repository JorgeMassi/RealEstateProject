import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { LoginRequest } from '../../models/login/loginRequest/login-request';
import { LoginResponse } from '../../models/login/loginResponse/login-response';
import { environment } from '../../../environments/environment.development';
import { Observable, tap } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  url:string;

  constructor(private http: HttpClient) {
      this.url = environment.apiUrl + '/Authentication/login';
  }

  public login(body: LoginRequest): Observable<LoginResponse> {
    console.log(body);
    
    return this.http.post<LoginResponse>(this.url, body).pipe(
      tap((data) => {
        localStorage.setItem('token', data.token);
        console.log(data);
      })
    );
  }
}

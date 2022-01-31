import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor() { }

  login() {
    const token = '';
    localStorage.setItem('token', token);

  }

  logout() {
    localStorage.clear();
  }

  isAuthenticated(): boolean {
    return false;
  }
}

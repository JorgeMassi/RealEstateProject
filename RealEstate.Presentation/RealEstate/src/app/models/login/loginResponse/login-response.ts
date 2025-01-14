import { Role, User } from "../../roles/user/user";


export class LoginResponse {
    user: User;
    token: string;
    refreshToken: string;
  
    constructor(id: string, name?: string, email?: string, role: string | Role = Role.RegisteredUser) {
      this.user = new User(id, name, email, role);
      this.token = '';
      this.refreshToken = '';
    }
}

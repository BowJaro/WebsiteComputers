import { Component } from '@angular/core';
import { Validators, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  result: any;
  users:any;

  loginform = this.builder.group({
    username: this.builder.control('', Validators.required),
    password: this.builder.control('', Validators.required)
  });
  
  constructor(private builder: FormBuilder, private service: AuthService,
    private router: Router) {
      sessionStorage.clear();
  }

  proceedLogin() {
    this.service.getAll().subscribe((result) => {
      this.users = result;

      if (this.loginform.valid) {
        var tempId = this.getUserIdByUsername(this.loginform.value.username);
        if (tempId == null){
          alert('Wrong account!');
          return;
        }
        this.service.getUserbyCode(tempId).subscribe(item => {
          this.result = item;
          if (this.result.password === this.loginform.value.password) {
              sessionStorage.setItem('id',this.result.id);
              sessionStorage.setItem('username',this.result.username);
              sessionStorage.setItem('first_name',this.result.first_name);
              sessionStorage.setItem('last_name',this.result.last_name);
              sessionStorage.setItem('date_of_birth',this.result.date_of_birth);
              sessionStorage.setItem('email',this.result.email);
              sessionStorage.setItem('phone_number',this.result.phone_number);
              sessionStorage.setItem('password',this.result.password);
              sessionStorage.setItem('gender',this.result.gender);
              this.router.navigate(['']);
          } else {
            alert('Wrong password!');
          }
        });
      } else {
        alert('Please enter valid data.');
      }
    })
  }

  getUserIdByUsername(username: any): any{
    const user = this.users.find((u:any) => u.username === username);
    return user ? user.id : undefined;
  }
}

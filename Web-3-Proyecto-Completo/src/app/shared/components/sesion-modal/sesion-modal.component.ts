import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AuthService } from '../../services/auth.service';
import { LoginFormBase } from '../../Utils/loginForm';
import { HeaderComponent } from '../header/header.component';

@Component({
  selector: 'app-sesion-modal',
  templateUrl: './sesion-modal.component.html',
  styleUrls: ['./sesion-modal.component.scss']
})
export class SesionModalComponent implements OnInit {

  constructor(
    public loginForm: LoginFormBase,
    private authService: AuthService,
    private router: Router,
    private toastr: ToastrService,
  ) { }

  ngOnInit(): void {
  }

  onLogin() {
    if (this.loginForm.baseForm.invalid) {
      return;
    }
    this.authService.login(this.loginForm.baseForm.value).
      subscribe((res) => {
        if (res) {
          this.toastr.success("Sesión Inciada");
          this.router.navigate(['home']);
          //this.header._isLogin = true;
        }
      }, (err) => {
       this.toastr.error(err);
       console.log(err);
      });
  }
}

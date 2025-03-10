import { Component, OnInit } from '@angular/core';
import { UserForm } from 'src/app/shared/Utils/UserForm';
import { ToastrService } from 'ngx-toastr';
import { NewUserService } from 'src/app/shared/services/new-user.service';

@Component({
  selector: 'app-update-user',
  templateUrl: './update-user.component.html',
  styleUrls: ['./update-user.component.scss']
})
export class UpdateUserComponent implements OnInit {

  constructor(
    public userForm: UserForm,
    private usuariosSrv: NewUserService,
    private toastr: ToastrService
  ) { }

  modificar() {
    let user = JSON.parse(localStorage.getItem('user'));

    if (this.userForm.baseForm1.invalid) {
      alert('Formulario invalido');
    }

    const form = this.userForm.baseForm1.value;
    this.usuariosSrv.modificar(this.userForm.baseForm1.value,user._user.Id).subscribe(() => {
      this.toastr.success('Usuario Modificado')

    }, (err) => {
      console.log(err)
    })
  }
  

  ngOnInit(): void {
    this.getUser()
  }

  getUser(){
    let user = JSON.parse(localStorage.getItem('user'));
    this.userForm.baseForm1.get("identity").setValue(user._user.identity);
    this.userForm.baseForm1.get("full_name").setValue(user._user.full_name);
    this.userForm.baseForm1.get("birthday").setValue(user._user.birthday);
    this.userForm.baseForm1.get("phone").setValue(user._user.phone);
    this.userForm.baseForm1.get("email").setValue(user._user.phone);
    this.userForm.baseForm1.get("password").setValue(user._user.password);
  }

}

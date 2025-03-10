import { Inject } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ToastrService } from 'ngx-toastr';
import { combineAll } from 'rxjs/operators';
import { UsersService } from 'src/app/shared/services/users.service';
import { UserForm } from 'src/app/shared/Utils/UserForm';

@Component({
  selector: 'app-modal-user',
  templateUrl: './modal-user.component.html',
  styleUrls: ['./modal-user.component.css']
})
export class ModalUserComponent implements OnInit {
  constructor(
    @Inject(MAT_DIALOG_DATA) public data: any,
    public userFormlocal: UserForm,
    private srvUsers: UsersService,
    private toastr: ToastrService
  ) { }

  ngOnInit(): void {
  }

  guardar() {
    const form = this.userFormlocal.baseForm.value;
    if (this.userFormlocal.baseForm.invalid) {
      alert("Formulario Invalido");
      console.log(form);
    }
    this.srvUsers.guardar(form).subscribe((res) => {
      this.toastr.success("Usuario Registrado");
    }, (err) => {
      this.toastr.error("Error: Usuario No Registrado");
      console.log(err);
    })
  }
}

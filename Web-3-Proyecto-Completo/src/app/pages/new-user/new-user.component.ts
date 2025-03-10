import { Component, OnInit } from '@angular/core';
import { UserForm } from 'src/app/shared/Utils/UserForm';
import { ToastrService } from 'ngx-toastr';
import { NewUserService } from 'src/app/shared/services/new-user.service';



@Component({
  selector: 'app-new-user',
  templateUrl: './new-user.component.html',
  styleUrls: ['./new-user.component.scss']
})
export class NewUserComponent implements OnInit {

  selectedFile:File=null
  urls = []
  

  constructor(
    public userForm: UserForm,
    private usuariosSrv: NewUserService,
    private toastr: ToastrService
  ) { }


  url: string;
  onSelectFile(event) { // called each time file input changes
      if (event.target.files && event.target.files[0]) {
        var reader = new FileReader();

        reader.readAsDataURL(event.target.files[0]); // read file as data url

        reader.onload = (event:any) => { // called once readAsDataURL is completed
          this.url = event.target.result;
        }
      }
  }

  guardar() {
    console.log(this.userForm.baseForm1.value)

    if (this.userForm.baseForm1.invalid) {
      alert('Formulario invalido');
    }
    const form = this.userForm.baseForm1.value;
    this.usuariosSrv.save(this.userForm.baseForm1.value).subscribe(() => {
    this.toastr.success('Usuario Guardado')

    }, () => {
      this.toastr.error('Error al Guardado Usuario')
    })
  }

  ngOnInit(): void {
  }
  
}
import { formatDate } from '@angular/common';
import { HttpClient, HttpEventType } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { RestaurantService } from 'src/app/shared/services/restaurant.service';
import { RestaurantForm } from 'src/app/shared/Utils/RestaurantForm';




@Component({
  selector: 'app-new-restaurant',
  templateUrl: './new-restaurant.component.html',
  styleUrls: ['./new-restaurant.component.scss']
})
export class NewRestaurantComponent implements OnInit {
  contacto:FormGroup;
  urls = []

  selectedFile:File=null

  constructor(
    public restaurantForm: RestaurantForm, 
    private fb:FormBuilder, 
    private restaurantSrv: RestaurantService,
    private toastr: ToastrService
  ) { }


  // selectFiles(event) {

  //   if (event.target.files) {
  //     for (var i = 0; i < File.length; i++) {
  //       var reader = new FileReader()
  //       reader.readAsDataURL(event.target.files[i])
  //       reader.onload = (event: any) => {

  //         this.urls.push(event.target.result)

  //       }
  //     }
  //   }
  // }


 
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
    console.log(this.restaurantForm.baseForm1.value)

    if (this.restaurantForm.baseForm1.invalid) {
      alert('Formulario invalido');
    }

    const form = this.restaurantForm.baseForm1.value;
    this.restaurantSrv.save(this.restaurantForm.baseForm1.value).subscribe(() => {
    this.toastr.success('Res Guardado')

    }, () => {
      this.toastr.error('Error al Guardado Res')
    })
  }

  ngOnInit() {
    this.contacto= this.fb.group({
      telefonos: this.fb.array([this.fb.group({telefono:['']})])
    })
  }

  get getTelefonos(){
    return this.contacto.get('telefonos') as FormArray;
  }


  addTelefono(){
    const control = <FormArray>this.contacto.controls['telefono'];
    control.push(this.fb.group({telefono:[]}));
  }


  removeTelefono(index: number){
    const control = <FormArray>this.contacto.controls['telefono'];
    control.removeAt(index);
  }

//res, fotos , telefono
}
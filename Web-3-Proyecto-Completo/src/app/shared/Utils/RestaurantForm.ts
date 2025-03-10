import { Injectable } from "@angular/core";
import { FormBuilder, Validators } from "@angular/forms";

@Injectable({ providedIn: 'root' })
export class RestaurantForm {
    constructor(private fb: FormBuilder) { }
    baseForm1 = this.fb.group({
        identity: ['', [Validators.required,Validators.minLength (10),Validators.maxLength(13),Validators.pattern('^[0-9]+$')]],
        name: ['', [Validators.required, Validators.maxLength(75)]],
        address: ['', [Validators.required, Validators.maxLength(250)]],
        open_time: ['', [Validators.required]],
        close_time: ['', [Validators.required]],
        business_type: ['', [Validators.required]],
        user: ['', [Validators.required, Validators.maxLength(75)]],
        tel: ['', [Validators.required, Validators.minLength (8),Validators.maxLength(13),Validators.pattern('^[0-9]+$')]],
        img: ['', [Validators.required]]      
    });

    //photo: ['', [Validators.required]],
}
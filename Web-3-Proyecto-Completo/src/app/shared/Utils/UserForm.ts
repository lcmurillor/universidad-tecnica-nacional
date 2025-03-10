import { Injectable } from "@angular/core";
import { FormBuilder, Validators } from "@angular/forms";

@Injectable({ providedIn: 'root' })
export class UserForm {
    constructor(private fb: FormBuilder) { }
    baseForm1 = this.fb.group({
        identity: ['', [Validators.required]],
        full_name: ['', [Validators.required]],
        birthday: ['', [Validators.required]],
        phone: ['', [Validators.required]],
        email: ['', [Validators.required, Validators.email]],
        password: ['', [Validators.required]]
    });
    
}
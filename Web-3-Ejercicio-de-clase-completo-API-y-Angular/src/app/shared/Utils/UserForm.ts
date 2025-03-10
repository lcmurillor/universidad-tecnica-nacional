import { Injectable } from "@angular/core";
import { FormBuilder, Validators } from "@angular/forms";

@Injectable({ providedIn: 'root' })
export class UserForm {
    constructor(private fb: FormBuilder) { }
    baseForm = this.fb.group({
        username: ['', [Validators.required, Validators.email]],
        name: ['', [Validators.required]],
        surname1: ['', [Validators.required]],
        surname2: ['', [Validators.required]],
        gender: ['', [Validators.required]],
        password: ['', [Validators.required]],
        role: ['', [Validators.required]],
        status: ['', [Validators.required]]
    });
}
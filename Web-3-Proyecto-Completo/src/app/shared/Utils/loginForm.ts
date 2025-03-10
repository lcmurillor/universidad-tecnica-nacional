import { Injectable } from "@angular/core";
import { FormBuilder, Validators } from "@angular/forms";
@Injectable({ providedIn: 'root' })
export class LoginFormBase {
    private emailFormat = /\S+@\S+\.\S+/;
    errorMessage=null;
    constructor(private fb: FormBuilder) {}

    baseForm = this.fb.group({
        email: ['', [Validators.required, Validators.pattern(this.emailFormat)]],
        password: ['', [Validators.required, Validators.minLength(6)]]
    });
}
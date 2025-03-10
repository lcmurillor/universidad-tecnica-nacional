import { NgModule } from "@angular/core";
import {MatSidenavModule} from '@angular/material/sidenav/'
import {MatButtonModule} from '@angular/material/button'
import {MatToolbarModule} from '@angular/material/toolbar'
import {MatCardModule} from '@angular/material/card'
import {MatFormFieldModule} from '@angular/material/form-field'
import {MatInputModule} from '@angular/material/input'
import {MatTableModule} from '@angular/material/table'
import { MatPaginatorModule } from "@angular/material/paginator";
import {MatIconModule} from "@angular/material/icon";
import {MatDialogModule} from "@angular/material/dialog";
import {MatRadioModule} from "@angular/material/radio";
import {MatSelectModule} from '@angular/material/select'

const myModules = [
    MatSidenavModule, 
    MatButtonModule,
    MatToolbarModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    MatTableModule,
    MatPaginatorModule,
    MatIconModule,
    MatDialogModule,
    MatRadioModule,
    MatSelectModule
];
@NgModule({
    imports: [...myModules],
    exports: [...myModules]
})
export class MaterialModule { }
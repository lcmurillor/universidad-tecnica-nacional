import { NgModule } from '@angular/core';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatButtonModule} from '@angular/material/button';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatCardModule} from '@angular/material/card';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule } from '@angular/material/form-field';
import {MatTableModule} from '@angular/material/table';
import {MatMenuModule} from '@angular/material/menu';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatIconModule} from '@angular/material/icon';
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatDialogModule} from '@angular/material/dialog';
import { MatStepperModule } from '@angular/material/stepper';
import { ReactiveFormsModule } from '@angular/forms';
import { NgbNavConfig, NgbNavModule } from '@ng-bootstrap/ng-bootstrap';
import {MatTreeModule} from '@angular/material/tree';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

const materialsComponents=[
    MatSidenavModule,
    MatButtonModule,
    MatToolbarModule,
    MatCardModule,
    MatInputModule,
    MatFormFieldModule,
    MatTableModule,
    MatMenuModule,
    MatPaginatorModule,
    MatIconModule,
    MatCheckboxModule,
    MatDialogModule,
    MatStepperModule,
    ReactiveFormsModule,
    NgbNavModule,
    MatTreeModule,
    NgbModule
];

@NgModule({
    imports: [
      ...materialsComponents,
    ],
    exports:[
        ...materialsComponents
    ]
  })
  export class MaterialModule { }
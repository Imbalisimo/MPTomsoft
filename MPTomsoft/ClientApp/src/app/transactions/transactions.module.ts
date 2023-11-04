import { HttpClientModule } from "@angular/common/http";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { MomentDateModule } from "@angular/material-moment-adapter";
import { TransactionsPaymentComponent } from "./payment/transactions-payment.component";
import { TransactionsProductComponent } from "./product/transactions-product.component";
import { NgModule } from "@angular/core";
import { TransactionsRoutingModule } from "./transactions-routing.modules";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { MatFormFieldModule } from "@angular/material/form-field";
import { MatDatepickerModule } from "@angular/material/datepicker";
import { MatInputModule } from '@angular/material/input';

@NgModule({
    declarations: [
        TransactionsPaymentComponent,
        TransactionsProductComponent
    ],
    imports: [
        HttpClientModule,
        FormsModule,
        ReactiveFormsModule,
        BrowserAnimationsModule,
        MatFormFieldModule,
        MatInputModule,
        MatDatepickerModule,
        TransactionsRoutingModule
    ],
    providers: [],
})
export class TransactionsModule { }
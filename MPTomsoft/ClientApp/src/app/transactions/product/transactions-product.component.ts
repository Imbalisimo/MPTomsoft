import { Component, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { MAT_DATE_FORMATS } from '@angular/material/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import * as moment from 'moment';
import { TransactionProduct, TransactionProducts } from '../models/transactions.models';

export const DATE_FORMATS = {
  parse: {
    dateInput: 'D.M.YYYY',
  },
  display: {
    dateInput: 'D.M.YYYY',
    dateA11yLabel: 'D.M.YYYY'
  },
};

@Component({
  selector: 'app-transactions-product',
  templateUrl: './transactions-product.component.html',
  providers: [{provide: MAT_DATE_FORMATS, useValue: DATE_FORMATS}]
})
export class TransactionsProductComponent {
  public transactions: TransactionProduct[];
  public form: FormGroup;

  private baseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string, private fb: FormBuilder) {
    this.baseUrl = baseUrl;
    this.form = fb.group({
      uid: new FormControl("", Validators.required),
      dateFrom: new FormControl("", Validators.required),
      dateTo: new FormControl()
    })
  }

  public fetchTransactionsByProduct(uid: string, dateFrom: string, dateTo: string) {
    let query = new HttpParams()
      .set('uid', uid)
      .set('dateFrom', moment(dateFrom).format('D.M.YYYY'));
    if(dateTo)
      query.set('dateTo', moment(dateTo).format('D.M.YYYY'));
    this.http.get<TransactionProducts[]>(this.baseUrl + 'transaction/product?' + query ).subscribe(result => {
      this.transactions = result[0].obracun_artikli;
    }, error => console.error(error));
  }
}

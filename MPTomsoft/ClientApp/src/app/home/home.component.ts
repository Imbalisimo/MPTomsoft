import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { Articles } from "./models/articles.model"

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public articles: Articles[] = [];
  public form: FormGroup;

  private baseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string, private fb: FormBuilder) {
    this.baseUrl = baseUrl;
    this.fetchArticles();
    this.form = fb.group({
      input: new FormControl()
    })
  }

  public fetchArticles(value?: string) {
    let query = value ? '?query=' + value : ''
    this.http.get<Articles[]>(this.baseUrl + 'article' + query ).subscribe(result => {
      this.articles = result;
    }, error => console.error(error));
  }
}

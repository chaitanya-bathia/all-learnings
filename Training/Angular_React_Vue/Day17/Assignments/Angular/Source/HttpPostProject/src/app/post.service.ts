import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Post } from './Models/posts';
import { Observable,throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  hosturl="https://gorest.co.in/public/v2/";
  token="16a95a5b7206ecf08468f8beabf90c5f8a29515ef2ecf935a13536c12ee3e3c6";

  constructor(private http:HttpClient) { }

  getPosts():Observable<Array<Post>> 
  {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        Authorization:`Bearer ${this.token}`

      })
    }
  var call= this.http.get<Array<Post>>(`${this.hosturl}posts`,httpOptions) 
  return call;
   }

  postPost(post:Post)
  {
    const httpOptions = {
      headers:new HttpHeaders({
        'Content-Type':'application/json',
        Authorization:`Bearer ${this.token}`
      })
    }
    return this.http.post<Post>(`${this.hosturl}posts`,post,httpOptions);
  }

  putPost(post:Post, id:number):Observable<Post>{
    const httpOptions = {
      headers:new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: `Bearer ${this.token}`
      })
    }
    return this.http.put<Post>(`${this.hosturl}posts/${id}`,post,httpOptions);
  }

  deletePost(id:number)
  {
    const httpOptions = {
      headers:new HttpHeaders({
        'Content-Type': 'application/json',
        Authorization: `Bearer ${this.token}`
      })
    }
    this.http.delete(`${this.hosturl}posts/${id}`,httpOptions).subscribe(() => {console.log("data deleted")});
  }
}

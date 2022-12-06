import { Component,OnInit } from '@angular/core';
import { PostService } from './post.service';
import { Post } from './Models/posts';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  
  title = 'HttpPostProject';
  postProfile:FormGroup;
  post!:Post;
  posts: Array<Post>=[];
  postnew:any;

  constructor(private postService:PostService, private fb:FormBuilder)
  {
    this.postProfile = this.fb.group({
      id:[0],
      user_id:[0],
      title:[""],
      body:[""]
    })
  }
  


  ngOnInit(): void {
    this.postService.getPosts().subscribe((p:Array<Post>)=> {
      this.posts = p;

      console.log(p);
    })
  }
  postinfo(){
    console.log(this.postProfile.value);
    this.post = this.postProfile.value;
    this.postService.postPost(this.post).subscribe((arg:Post) => {
      this.post = arg;
      this.ngOnInit();
      console.log(this.post);
    })
  }

  editinfo(post:Post)
  {
    this.postProfile.setValue(post);
  }

  updateinfo()
  {
    this.post = this.postProfile.value;
    this.postService.putPost(this.post,this.post.id).subscribe((arg:Post) => {
      this.post=arg;
      console.log(this.post);
    })
  }

  delete(post:Post)
  {

    console.log(this.postService.deletePost(post.id));
    
  }
}

import { Component, OnInit, Output, EventEmitter } from '@angular/core';


@Component({
  selector: 'app-post-list',
  templateUrl: './post-list.component.html',
  styleUrls: ['./post-list.component.css']
})
export class PostListComponent implements OnInit {

  @Output() dataEvent = new EventEmitter<any>();
  constructor() { }

  ngOnInit(): void {
  }

  arrPost:Array<Post>=[
    {postID:1,postName:"DemoPost1",postDescription:"Desc1",postedDate: new Date().toString(),postedImage:"https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/19170522-991d-463c-bd06-dad7881ce4be/d5c94is-ae076799-c04c-4a7d-8158-64794407c25e.gif",isLiked:false},
    {postID:2,postName:"DemoPost2",postDescription:"Desc2",postedDate: new Date().toString(),postedImage:"https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/19170522-991d-463c-bd06-dad7881ce4be/d5c94is-ae076799-c04c-4a7d-8158-64794407c25e.gif",isLiked:false},
    {postID:3,postName:"DemoPost3",postDescription:"Desc3",postedDate: new Date().toString(),postedImage:"https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/19170522-991d-463c-bd06-dad7881ce4be/d5c94is-ae076799-c04c-4a7d-8158-64794407c25e.gif",isLiked:false},
  ];

  arrLiked:Array<Post>=[];

  like(post:Post)
  {
    post.isLiked=true;
    this.arrLiked.push(post);
    console.log(this.arrLiked);
    this.dataEvent.emit(this.arrLiked);
  }

}

class Post
{
  postID:number;
  postName:string;
  postDescription:string;
  postedDate:string;
  postedImage:string;
  isLiked:boolean;

  constructor(id:number,name:string,desc:string,date:string,image:string,isLiked:boolean)
  {
    this.postID=id;
    this.postName=name;
    this.postDescription=desc,
    this.postedDate=date;
    this.postedImage=image;
    this.isLiked=isLiked;
  }
}

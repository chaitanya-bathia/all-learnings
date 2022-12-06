import React, {useState} from 'react';
import './App.css';

function PostList(props)
{
  let arrPost=[
    {postID:1,postName:"DemoPost1",postDescription:"Desc1",postedDate: new Date().toString(),postedImage:"https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/19170522-991d-463c-bd06-dad7881ce4be/d5c94is-ae076799-c04c-4a7d-8158-64794407c25e.gif",isLiked:false},
    {postID:2,postName:"DemoPost2",postDescription:"Desc2",postedDate: new Date().toString(),postedImage:"https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/19170522-991d-463c-bd06-dad7881ce4be/d5c94is-ae076799-c04c-4a7d-8158-64794407c25e.gif",isLiked:false},
    {postID:3,postName:"DemoPost3",postDescription:"Desc3",postedDate: new Date().toString(),postedImage:"https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/i/19170522-991d-463c-bd06-dad7881ce4be/d5c94is-ae076799-c04c-4a7d-8158-64794407c25e.gif",isLiked:false},
  ];

  let [arrLiked,addLiked]=useState([]);


  
  return(
    <div className="container-fluid">
    <div className="row">
        <div className="col text-center bg-dark text-white">
            <h1>Post List</h1>
        </div>
    </div>
    <div className="row">
        <div className="col">
            <table className="table table-striped table-hover">
                <caption hidden>Post List Table</caption>
                <thead>
                    <tr>
                        <td>Post ID</td>
                        <td>Name</td>
                        <td>Description</td>
                        <td>Date</td>
                        <td>Image</td>
                        <td>Like</td>
                    </tr>
                </thead>
                <tbody>
                    {arrPost.map((post)=>
                    {
                      return(
                        <tr key={post.postID}>
                          <td>{post.postID}</td>
                          <td>{post.postName}</td>
                          <td>{post.postDescription}</td>
                          <td>{post.postedDate}</td>
                          <td><img src={post.postedImage} alt="img"></img></td>
                          <td><button className="btn btn-primary" onClick={()=>{addLiked((p)=>[...arrLiked,post]); console.log(arrLiked); props.getData(arrLiked)}} >Like</button></td>
                        </tr>
                      )
                    })}
                </tbody>
            </table>
        </div>
    </div>
</div>
  )
}

function App() {

  const [arrLiked, setLiked] = useState([])
  function saveArray(arrLiked)
  {
    setLiked(arrLiked);
  }
  return (
    <div className="App">
      <PostList getData={saveArray}></PostList>
      <button className='btn btn-dark'>Liked: {arrLiked.length}</button>

      <table className="table table-striped table-hover">
                <caption hidden>Post List Table</caption>
                <thead>
                    <tr>
                        <td>Post ID</td>
                        <td>Name</td>
                        <td>Description</td>
                        <td>Date</td>
                        <td>Image</td>
                        <td>Like</td>
                    </tr>
                </thead>
                <tbody>
                    {arrLiked.map((post)=>
                    {
                      return(
                        <tr key={post.postID}>
                          <td>{post.postID}</td>
                          <td>{post.postName}</td>
                          <td>{post.postDescription}</td>
                          <td>{post.postedDate}</td>
                          <td><img src={post.postedImage} alt="img"></img></td>
                          
                        </tr>
                      )
                    })}
                </tbody>
            </table>
    </div>
  );
}

export default App;

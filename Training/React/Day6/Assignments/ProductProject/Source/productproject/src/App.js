import React, {useState} from 'react';
import './App.css';


function ProductList(props)
{
  const [arrProduct,addProd] = useState([]);

  function populateArray()
  {
    if(props.prod.productName===""||props.prod.price===0||props.prod.quantity===0)
    {
      alert("Invalid Data, Try again.");
    }
    else
    {
      props.prod.price = props.prod.price - (props.prod.price*0.05);
      addProd(()=>[...arrProduct, props.prod]);
    }
  };

  return(
    <div class="container">
      <div class="row">
      <button class="btn btn-success" onClick={populateArray}>Add Product</button>
      <p>{arrProduct.length}</p>

      <table class="table table-striped table-hover">
        <caption hidden>Table for products</caption>
        <thead>
          <tr>
            <td>Product Name</td>
            <td>Price</td>
            <td>Quantity</td>
          </tr>
        </thead>
        <tbody>
          {
            arrProduct.map((prod)=>{
              return(
                <tr>
                  <td>{prod.productName}</td>
                  <td>{prod.price}</td>
                  <td>{prod.quantity}</td>
                </tr>
              )
            })
          }
        </tbody>
      </table>
      </div>
    </div>
  )
}

function Product()
{

  var objProduct={productName:"",price:0,quantity:0};
  const [name , setName] = useState("");
  const [price,setPrice] = useState(0);
  const [quantity,setQuantity] = useState(0);

  objProduct.productName=name;
  objProduct.price=price;
  objProduct.quantity=quantity;
  
  return(
    <div>
      <div class="container-fluid">
      <div class="row">
          <div class="col text-center">
              <h1 class="bg-dark text-white">Product</h1>
          </div>
      </div>
      </div>
      <div class="row text-center">
          <div class="col-4 mx-auto">
              <label for="txtName">Product Name:</label>
              <input type="text" class="form-control" id="txtName" onChange={(e)=>setName(e.target.value)}/><br/>

              <label for="numPrice">Price:</label>
              <input type="number" class="form-control" id="numPrice" onChange={(e)=>setPrice(e.target.value)}/><br/>

              <label for="numQuantity">Quantity:</label>
              <input type="number" class="form-control" id="numQuantity" onChange={(e)=>setQuantity(e.target.value)}/><br/>

              
              <p>{objProduct.price}</p>
              <br/>
          </div>
      </div>
      <div class="row">
            <ProductList prod={objProduct}></ProductList>
      </div>
  </div>
  )
}

function App() {
  return (
    <div className="App">
      <Product ></Product>
    </div>
  );
}

export default App;

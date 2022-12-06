import { NavLink, Outlet, useSearchParams } from "react-router-dom";
import { getContacts } from "./data";


export default function Contact(){
    let contacts = getContacts();
    let [searchParams, setSearchParams] = useSearchParams();
    return(
        <div>
            <h2>This is contact.</h2>
            <input value={searchParams.get("filter")|| ""}
            onChange={(event)=>{
                let filter = event.target.value;
                if(filter){
                    setSearchParams({filter});
                }else{
                    setSearchParams({});
                }
            }}
            />
            {contacts.filter((contact) =>{
                let filter = searchParams.get("filter");
                if(!filter) return true;
                let name = contact.name.toLowerCase();
                return name.startsWith(filter.toLowerCase());
            })
            .map((contact)=>(
                <NavLink 
                style={({isActive})=>
                {return{display:"block",margin: "1rem 0", color:isActive?"red":"" };
                }} 
                to={`/contact/${contact.id}`} key={contact.id}>{contact.name}</NavLink> 
            ))}
            <Outlet/>
        </div>
    )
}


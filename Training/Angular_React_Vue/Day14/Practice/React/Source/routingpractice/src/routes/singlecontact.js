import { useParams } from "react-router-dom"
import { getSingleContact } from "./data";

export default function SingleContact(){
    let params = useParams();
    let contact = getSingleContact(parseInt(params.contactID));
    return (
        <h2>ID : {contact.id}, Name: {contact.name}, contact number: {contact.number}</h2>
        
    )
}
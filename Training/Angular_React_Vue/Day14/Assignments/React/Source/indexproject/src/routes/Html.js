import {Link, Outlet} from 'react-router-dom';
export default function HTML()
{
    return(
        <div className="container-fluid">
            <div className="row">
                <div className="col-3 bg-dark p-2">
                    <div><Link to="/html/day1" className="btn btn-warning m-2">Day1</Link></div>
                    <div><Link to="/html/day2" className="btn btn-warning m-2">Day2</Link></div>
                    <div><button className="btn btn-warning m-2">Day3</button></div>
                    <div><button className="btn btn-warning m-2">Day4</button></div>
                </div>
                <div className='col-9'>
                    <Outlet></Outlet>
                </div>
            </div>
            
        </div>
    )
}
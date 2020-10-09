import React from 'react';
import { NavLink } from 'react-router-dom';


export const Card = (props) => {
    let user = props.user;
    return (
        <div className="col-md-6">
            <div className="well well-sm">
                <div className="row">
                    <div className="col-md-4">
                        <img src={user.photo}
                            alt={user.name}
                            className="img-rounded img-responsive" />
                    </div>
                    <div className="col-md-8">
                        <h4>{user.name}
                            <i className={user.sex === 'F' ? 'fa fa-female' : 'fa fa-male'}></i>
                        </h4>
                        <small>
                            {user.city}, {user.country}
                            <i className="fa fa-map-marker"></i>
                        </small>
                        <p>
                            <i className="fa fa-envelope-o"></i>
                            {user.email}
                            <br />
                            <i className="fa fa-gift"></i>
                            {new Date(user.birthdate).toLocaleDateString()}
                        </p>
                        <NavLink className="btn btn-primary btn-sm" to="/">
                            <i className="fa fa-pencil"></i> &nbsp;Edit
                        </NavLink>
                        &nbsp;
                        <NavLink className="btn btn-danger btn-sm" ladda="isDeleting" to="/">
                            <i className="fa fa-trash"></i> &nbsp;Delete
                        </NavLink>

                    </div>
                </div>
            </div>
        </div>
    )
}
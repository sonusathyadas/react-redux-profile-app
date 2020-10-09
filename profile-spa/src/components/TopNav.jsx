
import React from 'react';
import { NavLink } from 'react-router-dom';

export const TopNav = () => {
    return (
        <nav className="navbar navbar-expand-lg navbar-dark bg-danger">
            <NavLink className="navbar-brand" exact to="/">Manage Contacts</NavLink>
            <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span className="navbar-toggler-icon"></span>
            </button>
            <div className="collapse navbar-collapse" id="navbarNav">
                <ul className="navbar-nav">
                    <li className="nav-item active">
                        <NavLink to='/' className="nav-link">Home</NavLink>
                    </li>
                    <li className="nav-item active">
                        <NavLink to='/add' className="nav-link">Create</NavLink>
                    </li>
                    <li className="nav-item active">
                        <NavLink to='/about' className="nav-link">About</NavLink>
                    </li>
                </ul>
            </div>
        </nav>
    )
}
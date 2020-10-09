import { ADD_PROFILE, DELETE_PROFILE, GET_PROFILES } from './action-types';

export const  loadProfiles = (profiles)=>{
    return{
        type:GET_PROFILES,
        profiles
    }
}

export const addProfile = (profile)=>{
    return {
        type:ADD_PROFILE,
        profile
    }
}

export const deleteProfile = (id)=>{
    return{
        type:DELETE_PROFILE,
        id
    }
}

//ASYNC ACTIONS
export function fetchProfiles() {
    return dispatch => {
        fetch("https://profile-services.azurewebsites.net/api/Profile")
            .then(resp => resp.json())
            .then(data => {
                dispatch(loadProfiles(data))
            });
    };
}

export function saveProfile(profile) {
    return dispatch => {
        return fetch('https://profile-services.azurewebsites.net/api/Profile', {
            method: 'post',
            body: JSON.stringify(profile),
            headers: {
                "Content-Type": "application/json"
            }
        })
        .then(handleResponse)
        .then(data=>dispatch(addProfile(data)));
    }
}

// handling response
function  handleResponse(response){
    if(response.ok){
        return response.json();
    }else{
        let error=new Error(response.statusText);
        error.response=response;
        throw error;
    }
}
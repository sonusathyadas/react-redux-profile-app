import * as actions from '../actions/action-types';

const initialState = []

export function profileReducer(state = initialState, action) {
    switch (action.type) {
        case actions.GET_PROFILES:
            state=[...action.profiles]
            return state;
        case actions.ADD_PROFILE:
            let profiles= [...state, action.profile];            
            return state;
        case actions.DELETE_PROFILE:
            //do delete here 
            return state;
        default:
            return state
    }
}
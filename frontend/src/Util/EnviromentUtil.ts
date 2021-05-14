export const isDev = () => {
    if (!process.env.NODE_ENV || process.env.NODE_ENV === "development") {
        return true;
    }
    return false;
};

// TODO: Replace with published api address.
export const baseAPIUrl = isDev() ? "https://localhost:5001" : "https://localhost:5001";
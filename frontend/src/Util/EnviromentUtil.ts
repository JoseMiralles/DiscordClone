export const isDev = () => {
    if (!process.env.NODE_ENV || process.env.NODE_ENV === "development") {
        return true;
    }
    return false;
};

export const baseAPIUrl = isDev() ? "https://localhost:5001" : "ACTUAL_URL";